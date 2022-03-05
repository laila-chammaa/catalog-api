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

run command to start up a mongodb instance in a docker container:

`docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo`

run command to start up a mongodb instance in a docker container with authentication:

`docker run -d --rm --name mongodb -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=password1 mongo`

run command to add the mongodb password to dotnet secrets

`dotnet user-secrets init`
