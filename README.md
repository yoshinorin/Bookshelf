# Bookshelf (WIP)

[![CI](https://github.com/yoshinorin/bookshelf/actions/workflows/ci.yml/badge.svg)](https://github.com/yoshinorin/bookshelf/actions/workflows/ci.yml)

# Build

```
$ dotnet publish -c Release
$ cd bin/Release/net8.0/publish/wwwroot

// serve content
$ python -m http.server 8080
```