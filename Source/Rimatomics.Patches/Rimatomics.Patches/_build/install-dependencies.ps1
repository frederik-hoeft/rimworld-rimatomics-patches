# Ensure abort after errors are encountered (may happen because of BOMs)
Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

$mod_root = (Get-Item -LiteralPath "${PSScriptRoot}/../../../..").FullName

# Read the hostconfig file
$config = Get-Content -LiteralPath "${PSScriptRoot}/hostconfig.json" -Raw | ConvertFrom-Json

# copy dependencies to dependencies folder
# add dependencies here
Copy-Item -LiteralPath "$($config.steam_root)/steamapps/workshop/content/294100/1127530465/1.5/Assemblies/Rimatomics.dll" -Destination "${PSScriptRoot}/dependencies/Rimatomics.dll"

Write-Host "Dependencies copied to dependencies folder"