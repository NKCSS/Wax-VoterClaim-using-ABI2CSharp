![Lumpi-Nick](https://rp.naw.io/img/lumpinick.png)
# Wax-VoterClaim-using-ABI2CSharp

This is a Proof of Concept program to interact with the [Wax](https://wax.io/) Blockchain using [C#](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/?view=vs-2022) to query voter status, claim your voter pay and vote for a proxy using the [ABI2CSharp](https://github.com/NKCSS/ABI2CSharp) and [EosSharp](https://github.com/NKCSS/eos-sharp) projects.

## Steps to reproduce setting up a blank project:

```cmd
REM Start VS2022 Developer commandline
cd \
mkdir PoC
cd PoC
git clone https://github.com/NKCSS/ABI2CSharp.git
git clone https://github.com/NKCSS/eos-sharp.git
curl -O https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
nuget restore ABI2CSharp\Abi2CSharp.csproj
nuget restore eos-sharp\EosSharp\EosSharp.sln
msbuild ABI2CSharp\Abi2CSharp.csproj
msbuild eos-sharp\EosSharp\EosSharp\EosSharp.csproj
PATH = %PATH%;C:\PoC\ABI2CSharp\bin\Debug\netcoreapp3.1
mkdir PoC
cd PoC
dotnet new console
dotnet add package Newtonsoft.Json
abi2csharp.exe eosio
devenv PoC.csproj
edit project file to include <LangVersion>10</LangVersion> after the TargetFramework element
```