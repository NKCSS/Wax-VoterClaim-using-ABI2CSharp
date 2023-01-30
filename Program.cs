//Abi2CSharp.Test.TestEosioTypeSerialization();
//Console.WriteLine("Serialization Tests Succeeded!");
//await Abi2CSharp.Test.Run();
using EosSharp;
using EosSharp.Core.Api.v1;
using EosSharp.Core.Exceptions;
using Abi2CSharp.Model.eosio;
using EosSharp.Core;
using eosio = Abi2CSharp.Contracts.eosio;
using System.Diagnostics;
using Newtonsoft.Json;

const int SecondsPerMinute = 60;
const int MinutesPerHour = 60;
const int HoursPerDay = 24;
const int SecondsPerDay = SecondsPerMinute * MinutesPerHour * HoursPerDay;

async Task<TimeSpan> WaitForChange(Func<Task<bool>> check, int checkIntervalMs = 1000)
{
    Stopwatch sw = new();
    sw.Start();
    bool hasChanged = await check();
    while(!hasChanged)
    {
        Thread.Sleep(checkIntervalMs);
        hasChanged = await check();
    }
    sw.Stop();
    return sw.Elapsed;
}

static async Task<(string result, string tx, bool error)> Execute(EosApi api, params EosSharp.Core.Api.v1.Action[] actions)
{
    (string result, string tx, bool error) result;
    var wax = new Eos(api.Config);
    var abiSerializer = new EosSharp.Core.Providers.AbiSerializationProvider(api);
    var trx = new Transaction { 
        max_net_usage_words = 0,
        max_cpu_usage_ms = 0,
        delay_sec = 0,
        context_free_actions = new(),
        transaction_extensions = new(),
        actions = actions.ToList(),
    };
    var packedTrx = await abiSerializer.SerializePackedTransaction(trx);
    var requiredKeys = (await api.Config.SignProvider.GetAvailableKeys()).ToList();
    var signatures = await api.Config.SignProvider.Sign(api.Config.ChainId, requiredKeys, packedTrx);
    try
    {
        string tx = await wax.CreateTransaction(trx);
        result = (null, tx, false);
    }
    catch (ApiErrorException ex)
    {
        Console.WriteLine("An error has occured:");
        var parts = ex.error.details.FirstOrDefault()?.message?.Split(':');
        if ((parts?.Length ?? 0) > 1)
        {
            result = (parts[1].Trim(), null, true);
        }
        else
        {
            result = (string.Join(Environment.NewLine, ex.error.details.Select(x => x.message)), null, true);
        }
        Console.WriteLine(result.result);
    }
    return result;
}

async Task CheckAndClaimVote()
{
    Name wallet = "nicknftstash", proxyToVoteFor = "waxcommunity";
    var api = new EosApi( new EosConfigurator { 
        SignProvider = null,// new EosSharp.Core.Providers.DefaultSignProvider(""),
        HttpEndpoint = "https://api.waxsweden.org",
        ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
    }, new HttpHandler());

    var voteInfo = (await eosio.Tables.voters.Query(api, lowerBound: wallet, upperBound: wallet)).rows.FirstOrDefault();

    Func<Task> voteForProxy = async () => {
        await Execute(api, eosio.Requests.voteproducer.CreateAction(wallet, new eosio.Types.voteproducer { voter = wallet, proxy = proxyToVoteFor }));
        var elapsed = await WaitForChange(async () => {
            var freshVoteInfo = (await eosio.Tables.voters.Query(api, lowerBound: wallet, upperBound: wallet)).rows.FirstOrDefault();
            return !(freshVoteInfo?.unpaid_voteshare_last_updated?.Equals(voteInfo?.unpaid_voteshare_last_updated ?? DateTime.MinValue) ?? true);
        });
        Console.WriteLine($"It took {elapsed} for the API to reflect the updated data...");
    };
    if (voteInfo == null)
    {
        // Never voted before
        Console.WriteLine($"Note vote info found; will vote for proxy '{proxyToVoteFor}'");
        await voteForProxy();
        Console.WriteLine("We voted for the proxy, now we need to wait 24h before we can claim our first WAX votereward");
    }
    else
    {
        var waxGlobal = (await eosio.Tables.global.Query(api)).rows[0];
        Console.WriteLine(JsonConvert.SerializeObject(waxGlobal, Formatting.Indented));
        var secondsElapsed = DateTime.UtcNow.Subtract(voteInfo.unpaid_voteshare_last_updated.Moment).TotalSeconds;
        var unpaid_voteshare = voteInfo.unpaid_voteshare + (voteInfo.unpaid_voteshare_change_rate * secondsElapsed);
        var reward = waxGlobal.voters_bucket * (unpaid_voteshare / waxGlobal.total_unpaid_voteshare);
        if (secondsElapsed > SecondsPerDay)
        {
            // day has passed since vote, so claimable
            Console.WriteLine($"Voter claimable: {(reward / 1e8):F8} WAX");
            await Execute(api, eosio.Requests.voterclaim.CreateAction(wallet, new eosio.Types.voterclaim { owner = wallet }));
            Console.WriteLine($"Renewing vote for proxy '{proxyToVoteFor}'");
            await voteForProxy();
        }
        else
        {
            Console.WriteLine($"Too early to claim voter pay (wait {voteInfo.unpaid_voteshare_last_updated.Moment.AddDays(1).Subtract(DateTime.UtcNow)}; we accumulated {(reward / 1e8):F8} WAX so far though...");
        }
    }
}

await CheckAndClaimVote();