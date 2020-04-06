# dotnet-api-sample
Sample dotnet core api using new fancy provisioning and DevOps tools :P 

## Idea and Motivation

The idea behind this project is to have a sort of handy example on how to do things in dotnet core for a REST API.

I want to use here some tools like terraform and kubernetes as well as monitoring tools like prometheus and grafana.

## Steps

First, let's create our sample API project and our solution file.

```sh
$ dotnet new sln -n Sample
$ dotnet new webapi -n Sample.API -o Sample.API
$ dotnet sln add Sample.API
```

In my local dev, I had to fix some certificate issues

```sh
dotnet dev-certs https --clean
dotnet dev-certs https 
dotnet dev-certs https --trust
```

Packages added

```sh
# Swagger
dotnet add src/Sample.API/Sample.API.csproj package Swashbuckle.AspNetCore
# Serilog and extensions
dotnet add src/Sample.API/Sample.API.csproj package Serilog
dotnet add src/Sample.API/Sample.API.csproj package Serilog.Sinks.Console
dotnet add src/Sample.API/Sample.API.csproj package Serilog.Sinks.File
dotnet add src/Sample.API/Sample.API.csproj package Serilog.Enrichers.Environment
dotnet add src/Sample.API/Sample.API.csproj package Serilog.Settings.Configuration
dotnet add src/Sample.API/Sample.API.csproj package Serilog.Enrichers.Thread
dotnet add src/Sample.API/Sample.API.csproj package Serilog.AspNetCore
```


## Next Steps

1. Add proper logging mechanism - DONE
2. Add Swagger - DONE
3. Add health checks
4. Add metrics endpoint
5. Dockerfile
6. TBD