# MiniCSC

A lightweight, open-source dynamic C# compiler CLI built on .NET and the Roslyn API (`Microsoft.CodeAnalysis.CSharp`).

## Features
- **Dynamic Compilation:** Compiles C# source code on-the-fly without needing Visual Studio.
- **In-Memory Execution:** Emits and runs compiled IL binaries directly from memory.
- **Diagnostics:** Provides real-time line-by-line syntax error reporting.

## Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or later

### Usage
```bash
# Run with default sample program
dotnet run
```
# Publish self-contained CLI executable
dotnet publish -c Release -r win-x64 --self-contained


**`auraecosystem/minicsc`** is a lightweight, command-line C# compiler utility built in .NET using Roslyn APIs to dynamically parse, compile, and execute C# code.

---

**Quick Setup & Execution**

```bash
# Clone repository
git clone https://github.com/auraecosystem/minicsc.git
cd minicsc

# Restore & run
dotnet restore
dotnet run

```

---

**Recommended `README.md` Template for this Repository**

```

## CI/CD

Continuous Integration is configured via GitHub Actions (`.github/workflows/build-and-test.yml`) to automatically build and test on every commit.

```

<ElicitationsGroup message="How would you like to update or extend the minicsc repo?">

{/* Reason: Offers relevant next steps for managing or expanding the project repository. */}

  <Elicitation label="Add command-line flags to compile local .cs files to .exe" query="Show me how to update minicsc to accept file paths via command line arguments like minicsc input.cs -o output.exe."/>
  <Elicitation label="Create a NuGet package workflow for minicsc" query="Show me how to set up a GitHub Actions workflow to publish minicsc as a .NET tool or NuGet package."/>
</ElicitationsGroup>

```
```
<oembedded>
<div class="badge-base LI-profile-badge" data-locale="en_US" data-size="medium" data-theme="dark" data-type="HORIZONTAL" data-vanity="web4hub" data-version="v1"><a class="badge-base__link LI-simple-link" href="https://ng.linkedin.com/in/web4hub?trk=profile-badge">Seriki Yakub</a></div>
              
