dotnet publish ./BlazorApp -p:PublishProfile="browser-wasm"
docker compose --project-name grvinokursky-blazor-app --file docker-compose.yml up --detach --build