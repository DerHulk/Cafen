# Cafen
## The *C*(ontainer)-(H)*afen*
The project name is a made-up word, composite from the word container and the german word for harbor.

Project target is to get in touche/learn with
[Docker-Registry ](https://docs.docker.com/registry/ "official link") and [Blazor](https://docs.microsoft.com/de-de/aspnet/core/blazor/?view=aspnetcore-6.0) and bring both together.

# Todo
- Index
- Flyouts
- Docker-Compose


# Setup Registry

docker run -d -p 5000:5000 --name registry2 -v $enterYourAbolutePathHere$\Cafen\DockerRegistryConfig.yml:/etc/docker/registry/config.yml registry:2

docker run --name keycloak -p 8080:8080 -e KEYCLOAK_ADMIN=admin -e KEYCLOAK_ADMIN_PASSWORD=admin quay.io/keycloak/keycloak:latest start-dev