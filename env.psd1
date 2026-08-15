[Environment]::SetEnvironmentVariable(
    "Path",
    [Environment]::GetEnvironmentVariable("Path", "User") + ";C:\Windows\Microsoft.NET\Framework64\v4.0.30319",
    "User"
)
