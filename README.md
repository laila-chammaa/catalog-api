## .NET Catalog API

created a REST API end-to-end from scratch using .NET 5 and C#.

learned about

- entities, repositories and controllers
- dependency injection, DTOs
- implementing post, put, delete and adding validations via data annotations
- persisting entities with MongoDB and running the MongoDB as a Docker container
- tasks, async and await
- enabling authentication in MongoDB using .NET Secret Manager
- adding health checks for readiness and liveness

---

### Setup

run to build the .net project

```
dotnet build
dotnet run
```

run command to start up a mongodb instance in a docker container with authentication:

```
docker run -d --rm --name mongodb -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=password1
```

run command to add the mongodb password to dotnet secrets

```
dotnet user-secrets init
```

to run in prod:

```
docker network create net5catalog
docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password=password1 --network=net5catalog catalog:v1
```
