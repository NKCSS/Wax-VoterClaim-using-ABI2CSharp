// Auto Generated, do not edit.
using System.Globalization;
using System.IO;
using Abi2CSharp.Model.eosio;
using EosSharp;
using EosSharp.Core;
using EosSharp.Core.Api.v1;
using System.Net.Http;
using System.Linq;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Abi2CSharp
{
    public static partial class Contracts
    {
        public static class eosio
        {
            public const string contract = "eosio";
            public static class Actions
            {
                public const string acceptprop = nameof(acceptprop);
                public const string activate = nameof(activate);
                public const string approve = nameof(approve);
                public const string awardgenesis = nameof(awardgenesis);
                public const string bidname = nameof(bidname);
                public const string bidrefund = nameof(bidrefund);
                public const string buyram = nameof(buyram);
                public const string buyrambytes = nameof(buyrambytes);
                public const string canceldelay = nameof(canceldelay);
                public const string claimfunds = nameof(claimfunds);
                public const string claimgbmprod = nameof(claimgbmprod);
                public const string claimgbmvote = nameof(claimgbmvote);
                public const string claimgenesis = nameof(claimgenesis);
                public const string claimrewards = nameof(claimrewards);
                public const string cleanvotes = nameof(cleanvotes);
                public const string delegatebw = nameof(delegatebw);
                public const string deleteauth = nameof(deleteauth);
                public const string delgenesis = nameof(delgenesis);
                public const string edcommittee = nameof(edcommittee);
                public const string editproposal = nameof(editproposal);
                public const string editproposer = nameof(editproposer);
                public const string editreviewer = nameof(editreviewer);
                public const string init = nameof(init);
                public const string linkauth = nameof(linkauth);
                public const string newaccount = nameof(newaccount);
                public const string onblock = nameof(onblock);
                public const string onerror = nameof(onerror);
                public const string refund = nameof(refund);
                public const string regcommittee = nameof(regcommittee);
                public const string regproducer = nameof(regproducer);
                public const string regproposal = nameof(regproposal);
                public const string regproposer = nameof(regproposer);
                public const string regproxy = nameof(regproxy);
                public const string regreviewer = nameof(regreviewer);
                public const string rejectfund = nameof(rejectfund);
                public const string rejectprop = nameof(rejectprop);
                public const string removerefund = nameof(removerefund);
                public const string rmvcommittee = nameof(rmvcommittee);
                public const string rmvcompleted = nameof(rmvcompleted);
                public const string rmvproducer = nameof(rmvproducer);
                public const string rmvproposer = nameof(rmvproposer);
                public const string rmvreject = nameof(rmvreject);
                public const string rmvreviewer = nameof(rmvreviewer);
                public const string sellram = nameof(sellram);
                public const string setabi = nameof(setabi);
                public const string setacctcpu = nameof(setacctcpu);
                public const string setacctnet = nameof(setacctnet);
                public const string setacctram = nameof(setacctram);
                public const string setalimits = nameof(setalimits);
                public const string setcode = nameof(setcode);
                public const string setparams = nameof(setparams);
                public const string setpriv = nameof(setpriv);
                public const string setram = nameof(setram);
                public const string setramrate = nameof(setramrate);
                public const string setwpsenv = nameof(setwpsenv);
                public const string setwpsstate = nameof(setwpsstate);
                public const string undelegatebw = nameof(undelegatebw);
                public const string unlinkauth = nameof(unlinkauth);
                public const string unregprod = nameof(unregprod);
                public const string updateauth = nameof(updateauth);
                public const string updtrevision = nameof(updtrevision);
                public const string voteproducer = nameof(voteproducer);
                public const string voteproposal = nameof(voteproposal);
                public const string voterclaim = nameof(voterclaim);
            }
            public static class Tables
            {
                // Rows are of type abi_hash. If you want helper code generated, enable includeEosSharpTest
                public static class abihash
                {
                    public const string TableName = "abihash";
                    public static Task<GetTableRowsResponse<Types.abi_hash>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.abi_hash>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.abihash.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type bid_refund. If you want helper code generated, enable includeEosSharpTest
                public static class bidrefunds
                {
                    public const string TableName = "bidrefunds";
                    public static Task<GetTableRowsResponse<Types.bid_refund>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.bid_refund>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.bidrefunds.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type committee. If you want helper code generated, enable includeEosSharpTest
                public static class committees
                {
                    public const string TableName = "committees";
                    public static Task<GetTableRowsResponse<Types.committee>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.committee>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.committees.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type delegated_bandwidth. If you want helper code generated, enable includeEosSharpTest
                public static class delband
                {
                    public const string TableName = "delband";
                    public static Task<GetTableRowsResponse<Types.delegated_bandwidth>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.delegated_bandwidth>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.delband.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type genesis_tokens. If you want helper code generated, enable includeEosSharpTest
                public static class genesis
                {
                    public const string TableName = "genesis";
                    public static Task<GetTableRowsResponse<Types.genesis_tokens>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.genesis_tokens>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.genesis.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type genesis_nonce. If you want helper code generated, enable includeEosSharpTest
                public static class genonce
                {
                    public const string TableName = "genonce";
                    public static Task<GetTableRowsResponse<Types.genesis_nonce>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.genesis_nonce>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.genonce.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type eosio_global_state. If you want helper code generated, enable includeEosSharpTest
                public static class global
                {
                    public const string TableName = "global";
                    public static Task<GetTableRowsResponse<Types.eosio_global_state>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.eosio_global_state>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.global.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type eosio_global_state2. If you want helper code generated, enable includeEosSharpTest
                public static class global2
                {
                    public const string TableName = "global2";
                    public static Task<GetTableRowsResponse<Types.eosio_global_state2>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.eosio_global_state2>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.global2.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type eosio_global_state3. If you want helper code generated, enable includeEosSharpTest
                public static class global3
                {
                    public const string TableName = "global3";
                    public static Task<GetTableRowsResponse<Types.eosio_global_state3>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.eosio_global_state3>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.global3.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type name_bid. If you want helper code generated, enable includeEosSharpTest
                public static class namebids
                {
                    public const string TableName = "namebids";
                    public static Task<GetTableRowsResponse<Types.name_bid>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.name_bid>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.namebids.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type producer_info. If you want helper code generated, enable includeEosSharpTest
                public static class producers
                {
                    public const string TableName = "producers";
                    public static Task<GetTableRowsResponse<Types.producer_info>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.producer_info>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.producers.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type producer_info2. If you want helper code generated, enable includeEosSharpTest
                public static class producers2
                {
                    public const string TableName = "producers2";
                    public static Task<GetTableRowsResponse<Types.producer_info2>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.producer_info2>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.producers2.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type proposal. If you want helper code generated, enable includeEosSharpTest
                public static class proposals
                {
                    public const string TableName = "proposals";
                    public static Task<GetTableRowsResponse<Types.proposal>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.proposal>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.proposals.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type proposer. If you want helper code generated, enable includeEosSharpTest
                public static class proposers
                {
                    public const string TableName = "proposers";
                    public static Task<GetTableRowsResponse<Types.proposer>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.proposer>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.proposers.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type exchange_state. If you want helper code generated, enable includeEosSharpTest
                public static class rammarket
                {
                    public const string TableName = "rammarket";
                    public static Task<GetTableRowsResponse<Types.exchange_state>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.exchange_state>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.rammarket.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type refund_request. If you want helper code generated, enable includeEosSharpTest
                public static class refunds
                {
                    public const string TableName = "refunds";
                    public static Task<GetTableRowsResponse<Types.refund_request>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.refund_request>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.refunds.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type reviewer. If you want helper code generated, enable includeEosSharpTest
                public static class reviewers
                {
                    public const string TableName = "reviewers";
                    public static Task<GetTableRowsResponse<Types.reviewer>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.reviewer>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.reviewers.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type user_resources. If you want helper code generated, enable includeEosSharpTest
                public static class userres
                {
                    public const string TableName = "userres";
                    public static Task<GetTableRowsResponse<Types.user_resources>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.user_resources>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.userres.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type voter_info. If you want helper code generated, enable includeEosSharpTest
                public static class voters
                {
                    public const string TableName = "voters";
                    public static Task<GetTableRowsResponse<Types.voter_info>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.voter_info>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.voters.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type wpsenv. If you want helper code generated, enable includeEosSharpTest
                public static class wpsglobal
                {
                    public const string TableName = "wpsglobal";
                    public static Task<GetTableRowsResponse<Types.wpsenv>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.wpsenv>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.wpsglobal.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type wps_global_state. If you want helper code generated, enable includeEosSharpTest
                public static class wpsstate
                {
                    public const string TableName = "wpsstate";
                    public static Task<GetTableRowsResponse<Types.wps_global_state>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.wps_global_state>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.wpsstate.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
                // Rows are of type wps_voter. If you want helper code generated, enable includeEosSharpTest
                public static class wpsvoters
                {
                    public const string TableName = "wpsvoters";
                    public static Task<GetTableRowsResponse<Types.wps_voter>> Query(EosApi api, bool reverse = false, uint? keyIndex = null, string search = null, string lowerBound = null, string upperBound = null, string scope = null, int maxResults = 10) 
                        => api.GetTableRows<Types.wps_voter>(new GetTableRowsRequest()
                        {
                            json = true,
                            code = Contracts.eosio.contract,
                            scope = scope ?? Contracts.eosio.contract,
                            table = Contracts.eosio.Tables.wpsvoters.TableName,
                            reverse = reverse,
                            show_payer = false,
                            index_position = keyIndex,
                            lower_bound = search ?? lowerBound,
                            upper_bound = search ?? upperBound,
                            limit = maxResults,
                        });
                }
            }
            public static class Types
            {
                public class abi_hash {
                    public Model.eosio.Name owner  { get; set; }
                    public Model.eosio.CheckSum256 hash  { get; set; }
                }
                public class acceptprop {
                    public Model.eosio.Name reviewer  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                }
                public class activate {
                    public Model.eosio.CheckSum256 feature_digest  { get; set; }
                }
                public class approve {
                    public Model.eosio.Name reviewer  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                }
                public class authority {
                    public uint threshold  { get; set; }
                    public key_weight[] keys  { get; set; }
                    public permission_level_weight[] accounts  { get; set; }
                    public wait_weight[] waits  { get; set; }
                }
                public class awardgenesis {
                    public Model.eosio.Name receiver  { get; set; }
                    public Model.eosio.Asset tokens  { get; set; }
                    public ulong nonce  { get; set; }
                }
                public class bid_refund {
                    public Model.eosio.Name bidder  { get; set; }
                    public Model.eosio.Asset amount  { get; set; }
                }
                public class bidname {
                    public Model.eosio.Name bidder  { get; set; }
                    public Model.eosio.Name newname  { get; set; }
                    public Model.eosio.Asset bid  { get; set; }
                }
                public class bidrefund {
                    public Model.eosio.Name bidder  { get; set; }
                    public Model.eosio.Name newname  { get; set; }
                }
                public class block_header {
                    public uint timestamp  { get; set; }
                    public Model.eosio.Name producer  { get; set; }
                    public ushort confirmed  { get; set; }
                    public Model.eosio.CheckSum256 previous  { get; set; }
                    public Model.eosio.CheckSum256 transaction_mroot  { get; set; }
                    public Model.eosio.CheckSum256 action_mroot  { get; set; }
                    public uint schedule_version  { get; set; }
                    public producer_schedule? new_producers  { get; set; }
                }
                public class blockchain_parameters {
                    public ulong max_block_net_usage  { get; set; }
                    public uint target_block_net_usage_pct  { get; set; }
                    public uint max_transaction_net_usage  { get; set; }
                    public uint base_per_transaction_net_usage  { get; set; }
                    public uint net_usage_leeway  { get; set; }
                    public uint context_free_discount_net_usage_num  { get; set; }
                    public uint context_free_discount_net_usage_den  { get; set; }
                    public uint max_block_cpu_usage  { get; set; }
                    public uint target_block_cpu_usage_pct  { get; set; }
                    public uint max_transaction_cpu_usage  { get; set; }
                    public uint min_transaction_cpu_usage  { get; set; }
                    public uint max_transaction_lifetime  { get; set; }
                    public uint deferred_trx_expiration_window  { get; set; }
                    public uint max_transaction_delay  { get; set; }
                    public uint max_inline_action_size  { get; set; }
                    public ushort max_inline_action_depth  { get; set; }
                    public ushort max_authority_depth  { get; set; }
                }
                public class buyram {
                    public Model.eosio.Name payer  { get; set; }
                    public Model.eosio.Name receiver  { get; set; }
                    public Model.eosio.Asset quant  { get; set; }
                }
                public class buyrambytes {
                    public Model.eosio.Name payer  { get; set; }
                    public Model.eosio.Name receiver  { get; set; }
                    public uint bytes  { get; set; }
                }
                public class canceldelay {
                    public permission_level canceling_auth  { get; set; }
                    public Model.eosio.CheckSum256 trx_id  { get; set; }
                }
                public class claimfunds {
                    public Model.eosio.Name account  { get; set; }
                }
                public class claimgbmprod {
                    public Model.eosio.Name owner  { get; set; }
                }
                public class claimgbmvote {
                    public Model.eosio.Name owner  { get; set; }
                }
                public class claimgenesis {
                    public Model.eosio.Name claimer  { get; set; }
                }
                public class claimrewards {
                    public Model.eosio.Name owner  { get; set; }
                }
                public class cleanvotes {
                    public Model.eosio.Name reviewer  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                    public ulong begin  { get; set; }
                    public ulong end  { get; set; }
                }
                public class committee {
                    public Model.eosio.Name committeeman  { get; set; }
                    public string category  { get; set; }
                    public bool is_oversight  { get; set; }
                }
                public class connector {
                    public Model.eosio.Asset balance  { get; set; }
                    public double weight  { get; set; }
                }
                public class delegatebw {
                    public Model.eosio.Name from  { get; set; }
                    public Model.eosio.Name receiver  { get; set; }
                    public Model.eosio.Asset stake_net_quantity  { get; set; }
                    public Model.eosio.Asset stake_cpu_quantity  { get; set; }
                    public bool transfer  { get; set; }
                }
                public class delegated_bandwidth {
                    public Model.eosio.Name from  { get; set; }
                    public Model.eosio.Name to  { get; set; }
                    public Model.eosio.Asset net_weight  { get; set; }
                    public Model.eosio.Asset cpu_weight  { get; set; }
                }
                public class deleteauth {
                    public Model.eosio.Name account  { get; set; }
                    public Model.eosio.Name permission  { get; set; }
                }
                public class delgenesis {
                    public ulong nonce  { get; set; }
                }
                public class edcommittee {
                    public Model.eosio.Name committeeman  { get; set; }
                    public string category  { get; set; }
                    public bool is_oversight  { get; set; }
                }
                public class editproposal {
                    public Model.eosio.Name proposer  { get; set; }
                    public Model.eosio.Name committee  { get; set; }
                    public ushort subcategory  { get; set; }
                    public string title  { get; set; }
                    public string summary  { get; set; }
                    public string project_img_url  { get; set; }
                    public string description  { get; set; }
                    public string roadmap  { get; set; }
                    public ulong duration  { get; set; }
                    public string[] members  { get; set; }
                    public Model.eosio.Asset funding_goal  { get; set; }
                    public uint total_iterations  { get; set; }
                }
                public class editproposer {
                    public Model.eosio.Name account  { get; set; }
                    public string first_name  { get; set; }
                    public string last_name  { get; set; }
                    public string img_url  { get; set; }
                    public string bio  { get; set; }
                    public string country  { get; set; }
                    public string telegram  { get; set; }
                    public string website  { get; set; }
                    public string linkedin  { get; set; }
                }
                public class editreviewer {
                    public Model.eosio.Name committee  { get; set; }
                    public Model.eosio.Name reviewer  { get; set; }
                    public string first_name  { get; set; }
                    public string last_name  { get; set; }
                }
                public class eosio_global_state {
                    public ulong max_ram_size  { get; set; }
                    public ulong total_ram_bytes_reserved  { get; set; }
                    public long total_ram_stake  { get; set; }
                    public DateTime last_producer_schedule_update  { get; set; }
                    public Model.eosio.TimePoint last_pervote_bucket_fill  { get; set; }
                    public long pervote_bucket  { get; set; }
                    public long perblock_bucket  { get; set; }
                    public long voters_bucket  { get; set; }
                    public double total_voteshare_change_rate  { get; set; }
                    public double total_unpaid_voteshare  { get; set; }
                    public Model.eosio.TimePoint total_unpaid_voteshare_last_updated  { get; set; }
                    public uint total_unpaid_blocks  { get; set; }
                    public long total_activated_stake  { get; set; }
                    public Model.eosio.TimePoint thresh_activated_stake_time  { get; set; }
                    public ushort last_producer_schedule_size  { get; set; }
                    public double total_producer_vote_weight  { get; set; }
                    public DateTime last_name_close  { get; set; }
                }
                public class eosio_global_state2 {
                    public ushort new_ram_per_block  { get; set; }
                    public DateTime last_ram_increase  { get; set; }
                    public DateTime last_block_num  { get; set; }
                    public double total_producer_votepay_share  { get; set; }
                    public byte revision  { get; set; }
                }
                public class eosio_global_state3 {
                    public Model.eosio.TimePoint last_vpay_state_update  { get; set; }
                    public double total_vpay_share_change_rate  { get; set; }
                }
                public class exchange_state {
                    public Model.eosio.Asset supply  { get; set; }
                    public connector @base  { get; set; }
                    public connector quote  { get; set; }
                }
                public class genesis_nonce {
                    public ulong nonce  { get; set; }
                    public Model.eosio.Asset awarded  { get; set; }
                    public Model.eosio.Name receiver  { get; set; }
                }
                public class genesis_tokens {
                    public Model.eosio.Asset balance  { get; set; }
                    public Model.eosio.Asset unclaimed_balance  { get; set; }
                    public Model.eosio.TimePoint last_claim_time  { get; set; }
                    public Model.eosio.TimePoint last_updated  { get; set; }
                }
                public class init {
                    public ulong version  { get; set; }
                    public Model.eosio.Symbol core  { get; set; }
                }
                public class key_weight {
                    public string key  { get; set; }
                    public ushort weight  { get; set; }
                }
                public class linkauth {
                    public Model.eosio.Name account  { get; set; }
                    public Model.eosio.Name code  { get; set; }
                    public Model.eosio.Name type  { get; set; }
                    public Model.eosio.Name requirement  { get; set; }
                }
                public class name_bid {
                    public Model.eosio.Name newname  { get; set; }
                    public Model.eosio.Name high_bidder  { get; set; }
                    public long high_bid  { get; set; }
                    public Model.eosio.TimePoint last_bid_time  { get; set; }
                }
                public class newaccount {
                    public Model.eosio.Name creator  { get; set; }
                    public Model.eosio.Name name  { get; set; }
                    public authority owner  { get; set; }
                    public authority active  { get; set; }
                }
                public class onblock {
                    public block_header header  { get; set; }
                }
                public class onerror {
                    public string sender_id  { get; set; }
                    public byte[] sent_trx  { get; set; }
                }
                public class permission_level {
                    public Model.eosio.Name actor  { get; set; }
                    public Model.eosio.Name permission  { get; set; }
                }
                public class permission_level_weight {
                    public permission_level permission  { get; set; }
                    public ushort weight  { get; set; }
                }
                public class producer_info {
                    public Model.eosio.Name owner  { get; set; }
                    public double total_votes  { get; set; }
                    public string producer_key  { get; set; }
                    public bool is_active  { get; set; }
                    public string url  { get; set; }
                    public uint unpaid_blocks  { get; set; }
                    public Model.eosio.TimePoint last_claim_time  { get; set; }
                    public ushort location  { get; set; }
                }
                public class producer_info2 {
                    public Model.eosio.Name owner  { get; set; }
                    public double votepay_share  { get; set; }
                    public Model.eosio.TimePoint last_votepay_share_update  { get; set; }
                }
                public class producer_key {
                    public Model.eosio.Name producer_name  { get; set; }
                    public string block_signing_key  { get; set; }
                }
                public class producer_schedule {
                    public uint version  { get; set; }
                    public producer_key[] producers  { get; set; }
                }
                public class proposal {
                    public Model.eosio.Name proposer  { get; set; }
                    public ulong id  { get; set; }
                    public Model.eosio.Name committee  { get; set; }
                    public string category  { get; set; }
                    public ushort subcategory  { get; set; }
                    public string title  { get; set; }
                    public string summary  { get; set; }
                    public string project_img_url  { get; set; }
                    public string description  { get; set; }
                    public string roadmap  { get; set; }
                    public ulong duration  { get; set; }
                    public string[] members  { get; set; }
                    public Model.eosio.Asset funding_goal  { get; set; }
                    public double total_votes  { get; set; }
                    public byte status  { get; set; }
                    public Model.eosio.TimePointSec vote_start_time  { get; set; }
                    public Model.eosio.TimePointSec fund_start_time  { get; set; }
                    public uint iteration_of_funding  { get; set; }
                    public uint total_iterations  { get; set; }
                }
                public class proposer {
                    public Model.eosio.Name account  { get; set; }
                    public string first_name  { get; set; }
                    public string last_name  { get; set; }
                    public string img_url  { get; set; }
                    public string bio  { get; set; }
                    public string country  { get; set; }
                    public string telegram  { get; set; }
                    public string website  { get; set; }
                    public string linkedin  { get; set; }
                    public Model.eosio.TimePointSec last_claim_time  { get; set; }
                }
                public class refund {
                    public Model.eosio.Name owner  { get; set; }
                }
                public class refund_request {
                    public Model.eosio.Name owner  { get; set; }
                    public Model.eosio.TimePointSec request_time  { get; set; }
                    public Model.eosio.Asset net_amount  { get; set; }
                    public Model.eosio.Asset cpu_amount  { get; set; }
                }
                public class regcommittee {
                    public Model.eosio.Name committeeman  { get; set; }
                    public string category  { get; set; }
                    public bool is_oversight  { get; set; }
                }
                public class regproducer {
                    public Model.eosio.Name producer  { get; set; }
                    public string producer_key  { get; set; }
                    public string url  { get; set; }
                    public ushort location  { get; set; }
                }
                public class regproposal {
                    public Model.eosio.Name proposer  { get; set; }
                    public Model.eosio.Name committee  { get; set; }
                    public ushort subcategory  { get; set; }
                    public string title  { get; set; }
                    public string summary  { get; set; }
                    public string project_img_url  { get; set; }
                    public string description  { get; set; }
                    public string roadmap  { get; set; }
                    public ulong duration  { get; set; }
                    public string[] members  { get; set; }
                    public Model.eosio.Asset funding_goal  { get; set; }
                    public uint total_iterations  { get; set; }
                }
                public class regproposer {
                    public Model.eosio.Name account  { get; set; }
                    public string first_name  { get; set; }
                    public string last_name  { get; set; }
                    public string img_url  { get; set; }
                    public string bio  { get; set; }
                    public string country  { get; set; }
                    public string telegram  { get; set; }
                    public string website  { get; set; }
                    public string linkedin  { get; set; }
                }
                public class regproxy {
                    public Model.eosio.Name proxy  { get; set; }
                    public bool isproxy  { get; set; }
                }
                public class regreviewer {
                    public Model.eosio.Name committee  { get; set; }
                    public Model.eosio.Name reviewer  { get; set; }
                    public string first_name  { get; set; }
                    public string last_name  { get; set; }
                }
                public class rejectfund {
                    public Model.eosio.Name committeeman  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                    public string reason  { get; set; }
                }
                public class rejectprop {
                    public Model.eosio.Name reviewer  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                    public string reason  { get; set; }
                }
                public class removerefund {
                    public Model.eosio.Name account  { get; set; }
                    public Model.eosio.Asset tokens  { get; set; }
                }
                public class reviewer {
                    public Model.eosio.Name account  { get; set; }
                    public Model.eosio.Name committee  { get; set; }
                    public string first_name  { get; set; }
                    public string last_name  { get; set; }
                }
                public class rmvcommittee {
                    public Model.eosio.Name committeeman  { get; set; }
                }
                public class rmvcompleted {
                    public Model.eosio.Name reviewer  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                }
                public class rmvproducer {
                    public Model.eosio.Name producer  { get; set; }
                }
                public class rmvproposer {
                    public Model.eosio.Name account  { get; set; }
                }
                public class rmvreject {
                    public Model.eosio.Name reviewer  { get; set; }
                    public Model.eosio.Name proposer  { get; set; }
                }
                public class rmvreviewer {
                    public Model.eosio.Name committee  { get; set; }
                    public Model.eosio.Name reviewer  { get; set; }
                }
                public class sellram {
                    public Model.eosio.Name account  { get; set; }
                    public long bytes  { get; set; }
                }
                public class setabi {
                    public Model.eosio.Name account  { get; set; }
                    public byte[] abi  { get; set; }
                }
                public class setacctcpu {
                    public Model.eosio.Name account  { get; set; }
                    public long? cpu_weight  { get; set; }
                }
                public class setacctnet {
                    public Model.eosio.Name account  { get; set; }
                    public long? net_weight  { get; set; }
                }
                public class setacctram {
                    public Model.eosio.Name account  { get; set; }
                    public long? ram_bytes  { get; set; }
                }
                public class setalimits {
                    public Model.eosio.Name account  { get; set; }
                    public long ram_bytes  { get; set; }
                    public long net_weight  { get; set; }
                    public long cpu_weight  { get; set; }
                }
                public class setcode {
                    public Model.eosio.Name account  { get; set; }
                    public byte vmtype  { get; set; }
                    public byte vmversion  { get; set; }
                    public byte[] code  { get; set; }
                }
                public class setparams {
                    public blockchain_parameters @params  { get; set; }
                }
                public class setpriv {
                    public Model.eosio.Name account  { get; set; }
                    public byte is_priv  { get; set; }
                }
                public class setram {
                    public ulong max_ram_size  { get; set; }
                }
                public class setramrate {
                    public ushort bytes_per_block  { get; set; }
                }
                public class setwpsenv {
                    public uint total_voting_percent  { get; set; }
                    public uint duration_of_voting  { get; set; }
                    public uint max_duration_of_funding  { get; set; }
                    public uint total_iteration_of_funding  { get; set; }
                }
                public class setwpsstate {
                    public double total_stake  { get; set; }
                }
                public class undelegatebw {
                    public Model.eosio.Name from  { get; set; }
                    public Model.eosio.Name receiver  { get; set; }
                    public Model.eosio.Asset unstake_net_quantity  { get; set; }
                    public Model.eosio.Asset unstake_cpu_quantity  { get; set; }
                }
                public class unlinkauth {
                    public Model.eosio.Name account  { get; set; }
                    public Model.eosio.Name code  { get; set; }
                    public Model.eosio.Name type  { get; set; }
                }
                public class unregprod {
                    public Model.eosio.Name producer  { get; set; }
                }
                public class updateauth {
                    public Model.eosio.Name account  { get; set; }
                    public Model.eosio.Name permission  { get; set; }
                    public Model.eosio.Name parent  { get; set; }
                    public authority auth  { get; set; }
                }
                public class updtrevision {
                    public byte revision  { get; set; }
                }
                public class user_resources {
                    public Model.eosio.Name owner  { get; set; }
                    public Model.eosio.Asset net_weight  { get; set; }
                    public Model.eosio.Asset cpu_weight  { get; set; }
                    public long ram_bytes  { get; set; }
                }
                public class voteproducer {
                    public Model.eosio.Name voter  { get; set; }
                    public Model.eosio.Name proxy  { get; set; }
                    public Model.eosio.Name[] producers  { get; set; }
                }
                public class voteproposal {
                    public Model.eosio.Name voter_name  { get; set; }
                    public Model.eosio.Name[] proposals  { get; set; }
                }
                public class voter_info {
                    public Model.eosio.Name owner  { get; set; }
                    public Model.eosio.Name proxy  { get; set; }
                    public Model.eosio.Name[] producers  { get; set; }
                    public long staked  { get; set; }
                    public double unpaid_voteshare  { get; set; }
                    public Model.eosio.TimePoint unpaid_voteshare_last_updated  { get; set; }
                    public double unpaid_voteshare_change_rate  { get; set; }
                    public Model.eosio.TimePoint last_claim_time  { get; set; }
                    public double last_vote_weight  { get; set; }
                    public double proxied_vote_weight  { get; set; }
                    public bool is_proxy  { get; set; }
                    public uint flags1  { get; set; }
                    public uint reserved2  { get; set; }
                    public Model.eosio.Asset reserved3  { get; set; }
                }
                public class voterclaim {
                    public Model.eosio.Name owner  { get; set; }
                }
                public class wait_weight {
                    public uint wait_sec  { get; set; }
                    public ushort weight  { get; set; }
                }
                public class wps_global_state {
                    public double total_stake  { get; set; }
                }
                public class wps_voter {
                    public Model.eosio.Name owner  { get; set; }
                    public Model.eosio.Name[] proposals  { get; set; }
                    public double last_vote_weight  { get; set; }
                }
                public class wpsenv {
                    public uint total_voting_percent  { get; set; }
                    public uint duration_of_voting  { get; set; }
                    public uint max_duration_of_funding  { get; set; }
                    public uint total_iteration_of_funding  { get; set; }
                }
            }
            public static class Requests
            {
                const string DefaultPermission = "active";
                public class acceptprop : Types.acceptprop
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.acceptprop data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.acceptprop data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.acceptprop,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class activate : Types.activate
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.activate data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.activate data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.activate,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class approve : Types.approve
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.approve data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.approve data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.approve,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class awardgenesis : Types.awardgenesis
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.awardgenesis data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.awardgenesis data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.awardgenesis,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class bidname : Types.bidname
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.bidname data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.bidname data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.bidname,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class bidrefund : Types.bidrefund
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.bidrefund data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.bidrefund data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.bidrefund,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class buyram : Types.buyram
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.buyram data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.buyram data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.buyram,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class buyrambytes : Types.buyrambytes
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.buyrambytes data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.buyrambytes data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.buyrambytes,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class canceldelay : Types.canceldelay
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.canceldelay data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.canceldelay data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.canceldelay,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class claimfunds : Types.claimfunds
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimfunds data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimfunds data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.claimfunds,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class claimgbmprod : Types.claimgbmprod
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimgbmprod data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimgbmprod data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.claimgbmprod,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class claimgbmvote : Types.claimgbmvote
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimgbmvote data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimgbmvote data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.claimgbmvote,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class claimgenesis : Types.claimgenesis
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimgenesis data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimgenesis data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.claimgenesis,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class claimrewards : Types.claimrewards
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimrewards data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.claimrewards data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.claimrewards,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class cleanvotes : Types.cleanvotes
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.cleanvotes data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.cleanvotes data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.cleanvotes,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class delegatebw : Types.delegatebw
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.delegatebw data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.delegatebw data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.delegatebw,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class deleteauth : Types.deleteauth
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.deleteauth data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.deleteauth data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.deleteauth,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class delgenesis : Types.delgenesis
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.delgenesis data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.delgenesis data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.delgenesis,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class edcommittee : Types.edcommittee
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.edcommittee data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.edcommittee data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.edcommittee,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class editproposal : Types.editproposal
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.editproposal data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.editproposal data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.editproposal,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class editproposer : Types.editproposer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.editproposer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.editproposer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.editproposer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class editreviewer : Types.editreviewer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.editreviewer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.editreviewer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.editreviewer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class init : Types.init
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.init data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.init data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.init,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class linkauth : Types.linkauth
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.linkauth data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.linkauth data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.linkauth,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class newaccount : Types.newaccount
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.newaccount data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.newaccount data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.newaccount,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class onblock : Types.onblock
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.onblock data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.onblock data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.onblock,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class onerror : Types.onerror
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.onerror data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.onerror data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.onerror,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class refund : Types.refund
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.refund data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.refund data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.refund,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class regcommittee : Types.regcommittee
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regcommittee data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regcommittee data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.regcommittee,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class regproducer : Types.regproducer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproducer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproducer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.regproducer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class regproposal : Types.regproposal
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproposal data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproposal data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.regproposal,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class regproposer : Types.regproposer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproposer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproposer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.regproposer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class regproxy : Types.regproxy
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproxy data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regproxy data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.regproxy,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class regreviewer : Types.regreviewer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regreviewer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.regreviewer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.regreviewer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rejectfund : Types.rejectfund
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rejectfund data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rejectfund data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rejectfund,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rejectprop : Types.rejectprop
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rejectprop data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rejectprop data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rejectprop,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class removerefund : Types.removerefund
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.removerefund data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.removerefund data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.removerefund,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rmvcommittee : Types.rmvcommittee
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvcommittee data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvcommittee data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rmvcommittee,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rmvcompleted : Types.rmvcompleted
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvcompleted data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvcompleted data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rmvcompleted,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rmvproducer : Types.rmvproducer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvproducer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvproducer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rmvproducer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rmvproposer : Types.rmvproposer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvproposer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvproposer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rmvproposer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rmvreject : Types.rmvreject
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvreject data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvreject data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rmvreject,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class rmvreviewer : Types.rmvreviewer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvreviewer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.rmvreviewer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.rmvreviewer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class sellram : Types.sellram
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.sellram data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.sellram data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.sellram,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setabi : Types.setabi
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setabi data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setabi data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setabi,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setacctcpu : Types.setacctcpu
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setacctcpu data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setacctcpu data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setacctcpu,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setacctnet : Types.setacctnet
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setacctnet data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setacctnet data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setacctnet,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setacctram : Types.setacctram
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setacctram data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setacctram data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setacctram,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setalimits : Types.setalimits
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setalimits data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setalimits data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setalimits,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setcode : Types.setcode
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setcode data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setcode data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setcode,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setparams : Types.setparams
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setparams data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setparams data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setparams,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setpriv : Types.setpriv
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setpriv data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setpriv data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setpriv,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setram : Types.setram
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setram data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setram data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setram,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setramrate : Types.setramrate
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setramrate data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setramrate data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setramrate,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setwpsenv : Types.setwpsenv
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setwpsenv data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setwpsenv data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setwpsenv,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class setwpsstate : Types.setwpsstate
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setwpsstate data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.setwpsstate data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.setwpsstate,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class undelegatebw : Types.undelegatebw
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.undelegatebw data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.undelegatebw data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.undelegatebw,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class unlinkauth : Types.unlinkauth
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.unlinkauth data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.unlinkauth data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.unlinkauth,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class unregprod : Types.unregprod
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.unregprod data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.unregprod data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.unregprod,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class updateauth : Types.updateauth
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.updateauth data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.updateauth data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.updateauth,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class updtrevision : Types.updtrevision
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.updtrevision data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.updtrevision data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.updtrevision,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class voteproducer : Types.voteproducer
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.voteproducer data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.voteproducer data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.voteproducer,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class voteproposal : Types.voteproposal
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.voteproposal data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.voteproposal data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.voteproposal,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
                public class voterclaim : Types.voterclaim
                {                
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.voterclaim data) => CreateAction(wallet, data, DefaultPermission);
                    public static EosSharp.Core.Api.v1.Action CreateAction(Model.eosio.Name wallet, Types.voterclaim data, Model.eosio.Name permission)
                        =>
                        new EosSharp.Core.Api.v1.Action()
                        {
                            account = contract,
                            name = Actions.voterclaim,
                            authorization = new List<PermissionLevel>() { new PermissionLevel() { actor = wallet, permission = permission } },
                            data = data
                        };
                }
            }
            public static class Responses
            {
                public class abihash : Types.abi_hash
                {
                }
                public class bidrefunds : Types.bid_refund
                {
                }
                public class committees : Types.committee
                {
                }
                public class delband : Types.delegated_bandwidth
                {
                }
                public class genesis : Types.genesis_tokens
                {
                }
                public class genonce : Types.genesis_nonce
                {
                }
                public class global : Types.eosio_global_state
                {
                }
                public class global2 : Types.eosio_global_state2
                {
                }
                public class global3 : Types.eosio_global_state3
                {
                }
                public class namebids : Types.name_bid
                {
                }
                public class producers : Types.producer_info
                {
                }
                public class producers2 : Types.producer_info2
                {
                }
                public class proposals : Types.proposal
                {
                }
                public class proposers : Types.proposer
                {
                }
                public class rammarket : Types.exchange_state
                {
                }
                public class refunds : Types.refund_request
                {
                }
                public class reviewers : Types.reviewer
                {
                }
                public class userres : Types.user_resources
                {
                }
                public class voters : Types.voter_info
                {
                }
                public class wpsglobal : Types.wpsenv
                {
                }
                public class wpsstate : Types.wps_global_state
                {
                }
                public class wpsvoters : Types.wps_voter
                {
                }
            }
        }
    }
    public static class Extensions
    {
        const char NULL = '\0';
        const int BitsPerByte = 8;
        const int BytesPer256Bits = 256 / BitsPerByte;        
        const int Zero = (int)'0';
        const int HexAFOffset = 10;
        const int UpperCaseA = (int)'A';
        const int UpperCaseAOffset = UpperCaseA - HexAFOffset;
        const int LowerCaseA = (int)'a';
        const int LowerCaseAOffset = LowerCaseA - HexAFOffset;
        #region Name-based constants
        const int NameMaxCharLength = 13;
        /// <summary>
        /// The amount of bits an Antelope name is encoded into.
        /// </summary>
        const int NameBitLength = 64;
        /// <summary>
        /// The amount of bits we can use per character.
        /// </summary>
        const int BitsPerNameValue = 5;
        /// <summary>
        /// The amount of charcters that can use the full bit length we need (12)
        /// </summary>
        const int NameFullBitCharCount = NameBitLength / BitsPerNameValue;
        /// <summary>
        /// The amount of bits that can have the full-length (60 in our case)
        /// </summary>
        const int NameBitsWithFullBitLength = NameFullBitCharCount * BitsPerNameValue;
        /// <summary>
        /// The amount of bits that remain for the last value (4)
        /// </summary>
        const int NameRestBits = NameBitLength - NameBitsWithFullBitLength;
        /// <summary>
        /// The last bit index that has <see cref="BitsPerNameValue"/> bits per encoded character.
        /// </summary>
        /// <remarks>
        /// Indexes are 0-based, so we take the amount of bits that are full-length values and substract 1.
        /// </remarks>
        const int LastFullLengthNameBitIndex = NameBitsWithFullBitLength - 1;
        /// <summary>
        /// The bitmask we use to extract the bits from the value. We shift by the bit length (e.g. overshoot), 
        /// then substract 1 to get a full set of binary 1 flags for our desired bit length.
        /// </summary>
        const int NameValueBitMask = (1 << BitsPerNameValue) - 1;
        /// <summary>
        /// The bitmask we use to extract the bits from the value. We shift by the bit length (e.g. overshoot), 
        /// then substract 1 to get a full set of binary 1 flags for our desired bit length.
        /// </summary>
        const int NameRestBitMask = (1 << NameRestBits) - 1;
        #endregion
        static Dictionary<char, byte> CharByteLookup;
        static Dictionary<byte, char> ByteCharLookup;
        static Extensions()
        {
            CharByteLookup = new Dictionary<char, byte>();
            ByteCharLookup = new Dictionary<byte, char>();
            CharByteLookup.Add('.', 0);
            ByteCharLookup.Add(0, '.');
            for (byte i = 1; i <= 5; ++i)
            {
                CharByteLookup.Add(i.ToString()[0], i);
                ByteCharLookup.Add(i, i.ToString()[0]);
            }
            byte offset = 'a' - 6;
            for (char c = 'a'; c <= 'z'; ++c)
            {
                CharByteLookup.Add(c, (byte)((byte)c - offset));
                ByteCharLookup.Add((byte)((byte)c - offset), c);
            }
        }
        public static string ReadEosioString(this BinaryReader br) => System.Text.Encoding.UTF8.GetString(br.ReadBytes(br.DecodeInt32()));
        public static string ToName(this ulong value)
        {
            char[] result = new char[NameMaxCharLength];
            byte v;
            char c;
            int resultIndex = 0;
            // The first 60 bits are 5-bits per value; 
            for (int i = 0; i < NameBitsWithFullBitLength; i += BitsPerNameValue)
            {
                v = (byte)((value >> LastFullLengthNameBitIndex - i) & NameValueBitMask);
                c = ByteCharLookup[v];
                result[resultIndex++] = c;
            }
            v = (byte)(value & NameRestBitMask);
            c = ByteCharLookup[v];
            result[resultIndex] = c;
            // Strip any trailing 0-values (e.g. '.')
            return new string(result).TrimEnd(ByteCharLookup[0]);
        }
        public static ulong NameToLong(this string name)
        {
            ulong result = 0L;
            int bitIndex = 0, i;
            byte c;
            // Process the full-bit-length characters
            for (i = 0; i < NameFullBitCharCount; i++)
            {
                c = i < name.Length ? CharByteLookup[name[i]] : (byte)0;
                if ((c & 0b00001) == 0b00001) result += 1UL << (59 - bitIndex);
                if ((c & 0b00010) == 0b00010) result += 1UL << (60 - bitIndex);
                if ((c & 0b00100) == 0b00100) result += 1UL << (61 - bitIndex);
                if ((c & 0b01000) == 0b01000) result += 1UL << (62 - bitIndex);
                if ((c & 0b10000) == 0b10000) result += 1UL << (63 - bitIndex);
                bitIndex += 5;
            }
            // Process the last 4 bits
            c = i < name.Length ? CharByteLookup[name[i]] : (byte)0;
            if ((c & 0b0001) == 0b0001) result += 1UL;
            if ((c & 0b0010) == 0b0010) result += 1UL << 1;
            if ((c & 0b0100) == 0b0100) result += 1UL << 2;
            if ((c & 0b1000) == 0b1000) result += 1UL << 3;
            return result;
        }
        public static int GetHexVal(this char hex)
        {
            int val = (int)hex;
            if (val < UpperCaseA)
                return val - Zero;
            else if (val < LowerCaseA)
                return val - UpperCaseAOffset;
            return
                val - LowerCaseAOffset;
        }
        public static byte[] ToByteArrayFastest(this string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");
            int byteCount = hex.Length >> 1;

            byte[] arr = new byte[byteCount];

            for (int i = 0; i < byteCount; ++i)
            {
                arr[i] = (byte)((hex[i << 1].GetHexVal() << 4) + hex[(i << 1) + 1].GetHexVal());
            }

            return arr;
        }
        public static string ToHexUpper(this byte[] value)
        {
            char[] result = new char[value.Length * 2];
            int index = 0;
            byte b;
            for (int ix = 0; ix < result.Length; ix += 2)
            {
                b = value[index++];
                result[ix] = GetHexUpper(b / 16);
                result[ix + 1] = GetHexUpper(b % 16);
            }
            return new string(result);
        }
        public static string ToHexLower(this byte[] value)
        {
            char[] result = new char[value.Length * 2];
            int index = 0;
            byte b;
            for (int ix = 0; ix < result.Length; ix += 2)
            {
                b = value[index++];
                result[ix] = GetHexLower(b / 16);
                result[ix + 1] = GetHexLower(b % 16);
            }
            return new string(result);
        }
        static char GetHexUpper(int i)
        {
            if (i < 0 || i > 15) throw new ArgumentException("Value must be between 0 and 15");
            else if (i < 10) return (char)(i + '0');
            return (char)(i - 10 + 'A');
        }
        static char GetHexLower(int i)
        {
            if (i < 0 || i > 15) throw new ArgumentException("Value must be between 0 and 15");
            else if (i < 10) return (char)(i + '0');
            return (char)(i - 10 + 'a');
        }
    }
    public static class VariableLengthInteger
    {
        const int BitsPerByte = 8;
        const int DataBits = BitsPerByte - 1;
        const int DataBitMask = (1 << DataBits) - 1;
        const int ContinuationBit = 1 << DataBits;
        public static void EncodeInt32(this BinaryWriter writer, int value)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be 0 or greater");
            foreach(byte val in value.EncodeInt32())
                writer.Write(val);
        }
        public static IEnumerable<byte> EncodeInt32(this uint value)
        {
            do
            {
                // Grab the lowest 7-bits of the value
                byte lower7bits = (byte)(value & DataBitMask);
                // Then shift the value by 7 and check if there is any value left.
                value >>= DataBits;
                if (value > 0) // If anything remains, ensure the continuation bit is set by OR-ing with 10000000 (1 + 7 bits from the data)
                    lower7bits |= ContinuationBit;
                yield return lower7bits;
            } while (value > 0);
        }
        public static IEnumerable<byte> EncodeInt32(this int value)
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(value)} must be 0 or greater");
            foreach(var b in EncodeInt32((uint)value)) 
                yield return b;
        }
        public static int DecodeInt32(this BinaryReader reader)
        {
            if (reader == null) throw new ArgumentNullException(nameof(reader));
            bool more = true;
            int value = 0, shift = 0;
            while (more)
            {
                byte lower7bits = reader.ReadByte();
                more = (lower7bits & ContinuationBit) != 0;
                value |= (lower7bits & DataBitMask) << shift;
                shift += DataBits;
            }
            return value;
        }
        public static int DecodeInt32(this IEnumerable<byte> bytes, bool breakOnNoMore = false)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));
            bool more = true;
            int value = 0, shift = 0;
            foreach(byte lower7bits in bytes)
            {
                more = (lower7bits & ContinuationBit) != 0;
                value |= (lower7bits & DataBitMask) << shift;
                shift += DataBits;
                if (breakOnNoMore && !more) break;
            }
            if (more) throw new ArgumentException("Last byte still had the 'more' flag set!", nameof(bytes));
            return value;
        }
        public static int DecodeInt32(this MemoryStream ms)
        {
            if (ms == null) throw new ArgumentNullException(nameof(ms));
            bool more = true;
            int value = 0, shift = 0;
            while (more)
            {
                byte lower7bits = (byte)ms.ReadByte();
                more = (lower7bits & ContinuationBit) != 0;
                value |= (lower7bits & DataBitMask) << shift;
                shift += DataBits;
            }
            return value;
        }
    }    
    public class CustomJsonConverter<T>
        : JsonConverter
        where T : ICustomSerialize<T>
    {
        public override bool CanConvert(Type objectType) => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is ICustomSerialize<T> t) writer.WriteValue(t.Serialize());
        }
        public override bool CanRead { get => true; }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICustomSerialize<>)))
            {
                if ((existingValue ?? Activator.CreateInstance<T>()) is ICustomSerialize<T> t) return t.Deserialize(reader);
            }
            return null;
        }
    }
	namespace Model.eosio
	{
        public interface ICustomSerialize<T>
        {
            string Serialize();
            T Deserialize(JsonReader reader);
        }
        [JsonConverter(typeof(CustomJsonConverter<Asset>))]
	    public class Asset : ICustomSerialize<Asset>
	    {
		    const string EnglishCultureName = "en-GB";
		    static readonly CultureInfo EnglishCulture = new CultureInfo(EnglishCultureName);
		    public Symbol Token { get; set; }
		    public UInt64 Balance { get; set; }
		    [Newtonsoft.Json.JsonIgnore]
		    public decimal BalanceDecimal { get => Balance / (decimal)Token.Factor; set => Balance = (ulong)(value * (decimal)Token.Factor); }
		    /// <remarks>
		    /// We use the F string format so there is only a decimal, no thousand separator.
		    /// </remarks>
		    public override string ToString() => $"{BalanceDecimal.ToString($"F{Token.precision}", EnglishCulture)} {Token.name}";
            public Asset() { } // Empty constructor for serializing
		    public static implicit operator Asset(string value)
		    {
			    Asset result = new Asset();
			    string[] parts = value.Split(' ');
			    if (parts.Length != 2) throw new ArgumentException($"Cannot parse '{value}' as a valid token balance", nameof(value));
			    string[] valueParts = parts[0].Split('.');
			    result.Token = new Symbol(
				    name: parts[1], 
				    precision: (byte)(valueParts.Length == 2 ? valueParts[1].Length : 0)
			    );
			    if (decimal.TryParse(parts[0], NumberStyles.AllowDecimalPoint, EnglishCulture, out decimal balance)) result.BalanceDecimal = balance;
			    else throw new ArgumentException($"Unable to parse '{parts[0]}' as a valid decimal");
			    return result;
		    }
		    public static implicit operator string(Asset value) => value.ToString();
		    public string Serialize() => ToString();
		    public Asset Deserialize(JsonReader reader) => (string)reader.Value;
		    public override int GetHashCode() => ToString().GetHashCode();
		    public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
	    }
        [JsonConverter(typeof(CustomJsonConverter<CheckSum256>))]
        public class CheckSum256 : ICustomSerialize<CheckSum256>
        {
            const int BitsPerByte = 8;
            const int HexCharsPerByte = 2;
            internal const int ExpectedLength = (256 / BitsPerByte) * 2;
            byte[] _Raw;
            string _AsString;
            public byte[] Raw
            {
                get => _Raw;
                set
                {
                    _Raw = value;
                    _AsString = value.ToHexLower();
                }
            }
            public string AsString
            {
                get => _AsString;
                set
                {
                    _AsString = value;
                    _Raw = value.ToByteArrayFastest();
                }
            }
            public CheckSum256() { } // Empty constructor for serializing
            public CheckSum256(string value)
            {
                AsString = value;
            }
            public static implicit operator CheckSum256(string value)
            {
                int valueLength = value?.Length ?? 0;
                if (valueLength != ExpectedLength) throw new System.ArgumentException($"A {nameof(CheckSum256)} should be {ExpectedLength} bytes in length. Supplied value byte length: {valueLength}", nameof(value));
                else return new CheckSum256(value);
            }
            public static implicit operator string(CheckSum256 value) => value.AsString;
            public override string ToString() => AsString;
            public string Serialize() => AsString;
            public CheckSum256 Deserialize(JsonReader reader) => (string)reader.Value;
            public override int GetHashCode() => AsString.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }
        [JsonConverter(typeof(CustomJsonConverter<Name>))]
        public class Name : ICustomSerialize<Name>
        {
            ulong _Value;
            string _Name;
            public ulong Value 
            { 
                get => _Value; 
                set 
                {
                    if(value != _Value)
                    {
                        _Value = value;
                        _Name = value.ToName();
                    }
                } 
            }
            public string AsString { 
                get => _Name;
                set
                {
                    if(value != _Name)
                    {
                        _Name = value;
                        _Value = AsString.NameToLong();
                    }
                }
            }
            public Name() { } // Empty constructor for serializing
            public Name(string value)
            {
                AsString = value;
            }
            public Name(ulong value)
            {
                Value = value;
            }
            public static implicit operator ulong(Name value) => value.Value;
            public static implicit operator string (Name value) => value.AsString;
            public static implicit operator Name(ulong value) => new Name(value);
            public static implicit operator Name(string value) => new Name(value);
            public override string ToString() => AsString;
            public string Serialize() => AsString;
            public Name Deserialize(JsonReader reader) => (string)reader.Value;
            public override int GetHashCode() => AsString.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }        
	    [JsonConverter(typeof(CustomJsonConverter<Symbol>))]
	    public class Symbol : ICustomSerialize<Symbol>
	    {
		    const char Separator = ',';
            public byte precision { get; set; }
            public string name { get; set; }
		    /// <remarks>
		    /// <see cref="System.Math.Pow">System.Math.Pow(10, 0)</see> returns 1, 
		    /// otherwise, this should have been written with a <see cref="System.Math.Max"/>
		    /// </remarks>
		    [Newtonsoft.Json.JsonIgnore]
		    public double Factor { get => System.Math.Pow(10, precision); }
		    public Symbol() { } // Empty constructor for serializing
		    public Symbol(string name, byte precision) {
			    this.name = name;
			    this.precision = precision;
		    }
		    public static implicit operator Symbol(string value)
            {
			    string[] parts = value.Split(Separator);
			    if (parts.Length != 2) throw new System.ArgumentException($"Symbol should be precision, followed by name, separated by '{Separator}'", nameof(value));
			    else if (!byte.TryParse(parts[0], out byte precision)) throw new System.ArgumentException($"Can't parse '{parts[0]}' as precision", nameof(value));
			    else return new Symbol(parts[1], precision);
		    }
		    public static implicit operator string(Symbol value) => value.ToString();
		    public override string ToString() => $"{precision}{Separator}{name}";
		    public string Serialize() => ToString();
		    public Symbol Deserialize(JsonReader reader) => (string)reader.Value;
		    public override int GetHashCode() => ToString().GetHashCode();
		    public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
	    }
        [JsonConverter(typeof(CustomJsonConverter<TimePoint>))]
        public class TimePoint : ICustomSerialize<TimePoint>
        {
            ulong _Value;
            DateTime _Moment;
            public ulong Value 
            { 
                get => _Value; 
                set 
                {
                    if(value != _Value)
                    {
                        _Value = value;
                        _Moment = DateTime.UnixEpoch.AddMilliseconds(value);
                    }
                } 
            }
            public DateTime Moment
            { 
                get => _Moment;
                set
                {
                    if(value != _Moment)
                    {
                        _Moment = value;
                        _Value = (ulong)value.Subtract(DateTime.UnixEpoch).TotalMilliseconds;
                    }
                }
            }
            public TimePoint() { } // Empty constructor for serializing
            public TimePoint(ulong value)
            {
                Value = value;
            }
            public TimePoint(string value)
            {
                Moment = DateTime.SpecifyKind(DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture), DateTimeKind.Utc);
            }
            public TimePoint(DateTime value)
            {
                Moment = value;
            }
            public static implicit operator ulong(TimePoint value) => value.Value;
            public static implicit operator DateTime(TimePoint value) => value.Moment;
            public static implicit operator TimePoint(ulong value) => new TimePoint(value);
            public static implicit operator TimePoint(DateTime value) => new TimePoint(value);
            public static implicit operator TimePoint(string value) => new TimePoint(value);
            public override string ToString() => Moment.ToString("yyyy-MM-dd HH:mm:ss.fff");
            public string Serialize() => Value.ToString();
            /// <summary>
            /// NewtonSoft already deserializes the DateTime string properly, so we just need to ensure we specify it's in UTC, but we also support ulong and raw string.
            /// </summary>
            /// <param name="reader"></param>
            /// <returns></returns>
            public TimePoint Deserialize(JsonReader reader)
            {
                if (reader.Value is DateTime t) return DateTime.SpecifyKind(t, DateTimeKind.Utc);
                else if (reader.Value is string s) return ulong.TryParse(s, out ulong v) ? new TimePoint(v) : new TimePoint(s);
                else throw new ArgumentException($"Cannot deserialize '{reader.Value}' as a {nameof(TimePoint)}");
            }
            public override int GetHashCode() => Moment.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }
        [JsonConverter(typeof(CustomJsonConverter<TimePointSec>))]
        public class TimePointSec : ICustomSerialize<TimePointSec>
        {
            uint _Value;
            DateTime _Moment;
            public uint Value 
            { 
                get => _Value; 
                set 
                {
                    if(value != _Value)
                    {
                        _Value = value;
                        _Moment = DateTime.UnixEpoch.AddSeconds(value);
                    }
                } 
            }
            public DateTime Moment
            { 
                get => _Moment;
                set
                {
                    if(value != _Moment)
                    {
                        _Moment = value;
                        _Value = (uint)value.Subtract(DateTime.UnixEpoch).TotalSeconds;
                    }
                }
            }
            public TimePointSec() { } // Empty constructor for serializing
            public TimePointSec(uint value)
            {
                Value = value;
            }
            public TimePointSec(string value)
            {
                Moment = DateTime.SpecifyKind(DateTime.ParseExact(value, "yyyy-MM-dd'T'HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture), DateTimeKind.Utc);
            }
            public TimePointSec(DateTime value)
            {
                Moment = value;
            }
            public static implicit operator uint(TimePointSec value) => value.Value;
            public static implicit operator DateTime(TimePointSec value) => value.Moment;
            public static implicit operator TimePointSec(uint value) => new TimePointSec(value);
            public static implicit operator TimePointSec(DateTime value) => new TimePointSec(value);
            public static implicit operator TimePointSec(string value) => new TimePointSec(value);
            public override string ToString() => Moment.ToString("yyyy-MM-dd HH:mm:ss.fff");

            public string Serialize() => Value.ToString();
            /// <summary>
            /// NewtonSoft already deserializes the DateTime string properly, so we just need to ensure we specify it's in UTC, but we also support ulong and raw string.
            /// </summary>
            /// <param name="reader"></param>
            /// <returns></returns>
            public TimePointSec Deserialize(JsonReader reader)
            {
                if (reader.Value is DateTime t) return DateTime.SpecifyKind(t, DateTimeKind.Utc);
                else if (reader.Value is string s) return uint.TryParse(s, out uint v) ? new TimePointSec(v) : new TimePointSec(s);
                else throw new ArgumentException($"Cannot deserialize '{reader.Value}' as a {nameof(TimePointSec)}");
            }
            public override int GetHashCode() => Moment.GetHashCode();
            public override bool Equals(object obj) => obj?.GetHashCode().Equals(GetHashCode()) ?? false;
        }
	} 
    public static class Test
    {
        public static async Task Run()
        {
            var api = new EosApi(new EosConfigurator()
            {
                SignProvider = null,
                HttpEndpoint = "https://api.waxsweden.org",
                ChainId = "1064487b3cd1a897ce03ae5b6a865651747e2e152090f99c1d19d44e01aea5a4"
            }, new HttpHandler());
            var result = await Contracts.eosio.Tables.abihash.Query(api);
            Console.WriteLine($"First row from {Contracts.eosio.Tables.abihash.TableName} table: {JsonConvert.SerializeObject(result.rows.FirstOrDefault())}");
        }
        public static void TestEosioTypeSerialization()
        {
            string raw, json;
            raw = "1.00000000 WAX";
            Model.eosio.Asset a = raw;
            json = JsonConvert.SerializeObject(a);
            var ad = JsonConvert.DeserializeObject<Model.eosio.Asset>(json);
            if (!a.Equals(ad)) throw new ApplicationException($"Values don't match: {a} Vs {ad} ('{raw}' serialized: {json})");
            raw = new string('a', CheckSum256.ExpectedLength);
            Model.eosio.CheckSum256 c = raw;
            json = JsonConvert.SerializeObject(c);
            var cd = JsonConvert.DeserializeObject<Model.eosio.CheckSum256>(json);
            if (!c.Equals(cd)) throw new ApplicationException($"Values don't match: {c} Vs {cd} ('{raw}' serialized: {json})");
            raw = "y3zra.wam";
            Model.eosio.Name n = raw;
            json = JsonConvert.SerializeObject(n);
            var nd = JsonConvert.DeserializeObject<Model.eosio.Name>(json);
            if (!n.Equals(nd)) throw new ApplicationException($"Values don't match: {n} Vs {nd} ('{raw}' serialized: {json})");
            raw = "8,WAX";
            Model.eosio.Symbol s = raw;
            json = JsonConvert.SerializeObject(s);
            var sd = JsonConvert.DeserializeObject<Model.eosio.Symbol>(json);
            if (!s.Equals(sd)) throw new ApplicationException($"Values don't match: {s} Vs {sd} ('{raw}' serialized: {json})");
            raw = "2022-10-21T13:19:59.000";
            Model.eosio.TimePoint t = raw;
            json = JsonConvert.SerializeObject(t);
            var td = JsonConvert.DeserializeObject<Model.eosio.TimePoint>(json);
            if (!t.Equals(td)) throw new ApplicationException($"Values don't match: {t} Vs {td} ('{raw}' serialized: {json})");
            // Reuse raw value
            Model.eosio.TimePointSec ts = raw;
            json = JsonConvert.SerializeObject(ts);
            var tsd = JsonConvert.DeserializeObject<Model.eosio.TimePointSec>(json);
            if (!ts.Equals(tsd)) throw new ApplicationException($"Values don't match: {ts} Vs {tsd} ('{raw}' serialized: {json})");
        }
    }
}