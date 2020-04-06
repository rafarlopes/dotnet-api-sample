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

