<img src="assets/xbehave_256x256.png" width="128" />

# xBehave.net

_[![Xbehave NuGet version](https://img.shields.io/nuget/dt/Xbehave.svg?style=flat&label=nuget%3A%20Xbehave)](https://www.nuget.org/packages/Xbehave)_
_[![Xbehave.Core NuGet version](https://img.shields.io/nuget/dt/Xbehave.Core.svg?style=flat&label=nuget%3A%20Xbehave.Core)](https://www.nuget.org/packages/Xbehave.Core)_
_[![Build status](https://github.com/xbehave/xbehave.net/workflows/.github/workflows/ci.yml/badge.svg)](https://github.com/xbehave/xbehave.net/actions)_

_[![Join the chat at https://gitter.im/xbehave/xbehave.net](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/xbehave/xbehave.net?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)_
_[![Follow @xbehavenet](https://img.shields.io/badge/Twitter-Follow%20%40xbehavenet-blue.svg)](https://twitter.com/intent/follow?screen_name=xbehavenet)_

* [Quickstart](https://github.com/xbehave/xbehave.net/wiki/Quickstart)
* [Documentation](https://github.com/xbehave/xbehave.net/wiki)
* [FAQ](https://github.com/xbehave/xbehave.net/wiki/FAQ)

xBehave.net is an [xUnit.net](https://github.com/xunit/xunit) extension, available in [full](https://www.nuget.org/packages/Xbehave) or [minimal](https://www.nuget.org/packages/Xbehave.Core) form, for describing each step in a test with natural language.

Platform support: [.NET Standard 1.1 and upwards](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

## Packages

The [full `Xbehave` package](https://www.nuget.org/packages/Xbehave) depends on the [`xunit` package](https://www.nuget.org/packages/xunit/). That means you get the full suite of xUnit.net dependencies such as [`xunit.assert`](https://www.nuget.org/packages/xunit.assert/) and [`xunit.analyzers`](https://www.nuget.org/packages/xunit.analyzers/).

The [minimal `Xbehave.Core` package](https://www.nuget.org/packages/Xbehave.Core) depends on the [`xunit.core` package](https://www.nuget.org/packages/xunit/). That means you get only the minimum dependencies required to write and execute xBehave.net scenarios.

## Versions

xBehave.net follows the versioning scheme of xUnit.net. xUnit.net and xBehave.net do not follow SemVer and may introduce breaking changes in minor versions. Each minor version of xBehave.net is linked to the equivalent minor version of xUnit.net. The xBehave.net patch version is incremented to the next multiple of 100 each time it is linked to a new xUnit.net patch version. For example, xBehave.net 2.4.0 is linked with xUnit.net 2.4.0, and xBehave.net 2.4.100 is linked with xUnit 2.4.1.

A given xBehave.net patch version may introduce new features, fix bugs, or both.

---

<sub>xBehave.net logo designed by [Vanja Pakaski](https://github.com/vanpak).</sub>
