# test-submodules-backend-netcore

This is the ASP.NET Core backend part of an experimental Autodesk Forge sample app
that is split across multiple GitHub repositories.

## Prerequisites

- [Autodesk Forge app](https://forge.autodesk.com/en/docs/oauth/v2/tutorials/create-app)
- [.NET Core](https://dotnet.microsoft.com/download) (LTS version)
- [Git](https://git-scm.com)

## Getting started

- Clone this repository _with submodules_:
    ```
    git clone --recurse-submodules https://github.com/petrbroz/test-submodules-backend-netcore
    cd test-submodules-backend-netcore
    ```

- Install dependencies: `dotnet restore`

- Provide your Forge app client ID and secret via environment variables:

    | Bash (macOS/Linux) | Command Prompt (Windows) |
    |--------------------|--------------------------|
    |`export FORGE_CLIENT_ID=your-client-id`<br>`export FORGE_CLIENT_SECRET=your-client-secret`|`set FORGE_CLIENT_ID=your-client-id`<br>`set FORGE_CLIENT_SECRET=your-client-secret`|

- Run the server: `dotnet run`

### Visual Studio Code

If you're using [Visual Studio Code](https://code.visualstudio.com), make a copy the _.env\_template_ file
in the root folder, name it _.env_, and add your Forge client ID and client secret to it.
Now, you can run and debug your application from the editor using _Run_ > _Start Debugging_ or by pressing `f5`.
