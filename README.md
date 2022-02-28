# Cafen
## The *C*(ontainer)-(H)*afen*
The project name is a made-up word, composite from the word container and the german word for harbor.

Project target is to get in touche/learn with
[Docker-Registry ](https://docs.docker.com/registry/ "official link") and [Blazor](https://docs.microsoft.com/de-de/aspnet/core/blazor/?view=aspnetcore-6.0) and bring both together.

# Todo
- Index
- Flyouts
- Docker-Compose
- Write Tests


# Setup Registry

docker run -d -p 5000:5000 --name registry2 -v $enterYourAbolutePathHere$\Cafen\DockerRegistryConfig.yml:/etc/docker/registry/config.yml registry:2

docker run --name keycloak -p 8080:8080 -e KEYCLOAK_ADMIN=admin -e KEYCLOAK_ADMIN_PASSWORD=admin quay.io/keycloak/keycloak:latest start-dev

# Refs

- https://github.com/distribution/distribution/blob/main/docs/spec/auth/index.md
- https://github.com/distribution/distribution/blob/main/docs/spec/api.md#deleting-an-image
- https://stackoverflow.com/questions/25436742/how-to-delete-images-from-a-private-docker-registry
- https://docs.docker.com/registry/configuration/
- https://github.com/distribution/distribution/blob/main/cmd/registry/config-example.yml
- https://github.com/distribution/distribution
- https://docs.docker.com/registry/spec/auth/token/
- https://github.com/Joxit/docker-registry-ui
- https://stackoverflow.com/questions/59256798/how-to-use-bootstrap-modal-in-blazor-client-app
