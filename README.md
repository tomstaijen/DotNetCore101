# Your first project

## Install dotnet core

- Go to [dot.net](http://dot.net), click .net core
- Download and install .NET Core SDK for Windows

## Create your first project

```sh
dotnet new
dotnet restore
dotnet run
```
After some compilation noise, it will print: `Hello World!`

# Editors

## Visual Studio 2015

- Download and install Visual Studio 2015 Update 3
- Download and install .NET Core 1.0 for Visual Studio

Visual studio uses the (deprecated?) xproj-system. However, you can open a cli project by opening the project.json. It will generate an xproj-file while loading the project.

One big advantage of Visual Studio is the package manager to search for compatible packages.

## Visual Studio Code

Why would you want this? The goal of VSC is:
* to be fast as an editor
* still have the required features of an IDE.
* be keyboard oriented (yes, that's faster)

### Installation 
- Install [Visual Studio Code](https://code.visualstudio.com) 
- Start Visual Studio Code in a project directory (from a cmd prompt)

`code .`

Install the C# extensions

```c#
Ctrl+p // to bring up a multi-purpose command box`
```

`ext install c#`

Now, while opening netcore project folder, it should tell that you are working in C#.

*What else?*
* Decent language support
  * You can edit c# with syntax highlighting
  * (Ctrl+T to find symbol)
  * Ctrl+space for suggestions
  * CodeLens (immediate inline references)
  * Find references/Peek definition (right click)

You can debug by pressing the bug-like tab in the left menubar. Visual Studio Code uses the plugin system to comunicate with a c# language server called OmniSharp. 

[Complete list of keybindings](https://code.visualstudio.com/docs/customization/keybindings)

[More info on C# support for Visual Studio Code](https://code.visualstudio.com/Docs/languages/csharp)

# Running it on linux
```
vagrant init bento/centos-7.1
vagrant up
```

```
sudo yum install libunwind libicu
curl -sSL -o dotnet.tar.gz https://go.microsoft.com/fwlink/?LinkID=809131
sudo mkdir -p /opt/dotnet && sudo tar zxf dotnet.tar.gz -C /opt/dotnet
sudo ln -s /opt/dotnet/dotnet /usr/local/bin
```

# Portable vs native

[App Types doc](https://github.com/dotnet/core-docs/blob/master/docs/core/app-types.md)



# Support for our stack

* WebApi: YES
* RabbitMQ: WIP
* Masstransit: WIP
* Log4Net: no, alternative: Serilog
* Nancy: YES
* Cake: YES


# Project.json explained

[The documentation for project.json ](https://github.com/aspnet/Home/wiki/Project.json-file)

[Plans to move (back) to .csproj/MSBuild](https://blogs.msdn.microsoft.com/dotnet/2016/05/23/changes-to-project-json/)

Yes, they're moving back to csproj/msbuild (meh). However, some improvements are due:

* multi-targetting
* no need to have file lists

# .NET Standard library

What's that noise about .NET Standard? Read it [here](https://github.com/dotnet/core-docs/blob/master/docs/standard/library.md).

You can target a version of the standard library, so that you automatically support different target's that support this standard library version.
