# Bookshelf (WIP)

[![CI](https://github.com/yoshinorin/bookshelf/actions/workflows/ci.yml/badge.svg)](https://github.com/yoshinorin/bookshelf/actions/workflows/ci.yml)

# Build

```sh
$ dotnet publish -c Release
```

# Hot Reload

```sh
$ dotnet watch
```

# Serve

```sh
$ cd bin/Release/net8.0/publish/wwwroot

// serve content
$ python -m http.server 8080
```

# Book data structures (Draft)

create a JSON for the list of books. The structure of the JSON is as follows:

```json
[
  {
    "title": "Book Title 1",
    "genre": "Art",
    "readAt": 1722956400000,
    "url": "https://example.com/4908686149",
    "imageUrl": "https://example.com/image/4908686149"
  },
  {
    "title": "Book Title 2",
    "genre": "Music",
    "readAt": 1722956400000,
    "url": "https://example.com/4908686149",
    "imageUrl": "https://example.com/image/4908686149"
  }
]
```

## Using Stacks

|Stack|-|
|---|---|
|[Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)|-|
|[fluentui-blazor](https://github.com/microsoft/fluentui-blazor)| UI Framework |
|[GitHub Pages](https://pages.github.com/)| CI/CD |