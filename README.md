# CurseForge ApiProxy

This project is meant to run behind a reverse proxy, and serves as a proxy server that 3rd party developers can host themselves, to enable them to hide their API key from the public.

Default port is `36000` (3 = C, 6 = F)

Port can be customized by setting an environment variable (`CFPROXY_PORT`) to another port number

The CF Core API Key is set in the environment variable `CFPROXY_APIKEY`.
