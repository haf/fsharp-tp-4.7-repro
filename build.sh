#!/usr/bin/env bash
if [[ ! -d .paket ]]; then
  dotnet tool install  --tool-path .paket --version 5.216.0 paket
fi
dotnet restore
dotnet build Provider.DesignTime
dotnet build -verbosity:d "$@" | tee "log-$(date '+%d-%m-%y-%H-%M-%S').log"
