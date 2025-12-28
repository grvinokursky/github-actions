FROM nginx:stable-alpine3.19-slim
COPY ./art/blazor-app/browser-wasm /app/bin/
COPY nginx.conf /etc/nginx/conf.d/default.conf
STOPSIGNAL SIGQUIT
CMD ["nginx", "-g", "daemon off;"]
HEALTHCHECK CMD nc -vz -w1 127.0.0.1 80 || exit 1