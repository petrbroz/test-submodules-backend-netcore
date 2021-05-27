# test-submodules-backend-netcore

This is the ASP.NET Core backend part of an experimental Autodesk Forge sample app
that is split across multiple GitHub repositories, namely:

- Frontend (HTML, CSS, JavaScript): https://github.com/petrbroz/test-submodules-frontend
- Node.js backend: https://github.com/petrbroz/test-submodules-backend-nodejs
- .NET Core backend: https://github.com/petrbroz/test-submodules-backend-netcore

## Prerequisites

- [Autodesk Forge app](https://forge.autodesk.com/en/docs/oauth/v2/tutorials/create-app)
- [.NET Core](https://dotnet.microsoft.com/download) (LTS version)
- [Git](https://git-scm.com)

## Getting started

- Clone this repository **with submodules**:
    ```
    git clone --recurse-submodules https://github.com/petrbroz/test-submodules-backend-netcore
    cd test-submodules-backend-netcore
    ```

- Install .NET Core dependencies: `dotnet restore`

- Provide your Forge app client ID and secret via environment variables:

    | Bash (macOS/Linux) | Command Prompt (Windows) |
    |--------------------|--------------------------|
    |`export FORGE_CLIENT_ID=your-client-id`<br>`export FORGE_CLIENT_SECRET=your-client-secret`|`set FORGE_CLIENT_ID=your-client-id`<br>`set FORGE_CLIENT_SECRET=your-client-secret`|

    > Replace `your-client-id` and `your-client-secret` with your Forge app credentials.

- Run the server: `dotnet run`

### Visual Studio Code

If you're using [Visual Studio Code](https://code.visualstudio.com), make a copy the _.env\_template_ file
in the root folder, name it _.env_, and add your Forge client ID and client secret to it.
Now, you can run and debug your application from the editor using _Run_ > _Start Debugging_ or by pressing `f5`.

### Heroku Deployment

Heroku does [support git submodules](https://devcenter.heroku.com/articles/git-submodules)
when using the standard `git push heroku <branch>` deployment, meaning that if you have
the [Heroku CLI tool](https://devcenter.heroku.com/articles/heroku-cli) installed, you can simply do:

```bash
heroku login
heroku create your-heroku-app --buildpack https://github.com/jincod/dotnetcore-buildpack.git
heroku git:remote -a your-heroku-app
heroku config:set -a your-heroku-app FORGE_CLIENT_ID=your-client-id
heroku config:set -a your-heroku-app FORGE_CLIENT_SECRET=your-client-secret
git push heroku master
```

> Replace `your-client-id` and `your-client-secret` with your Forge app credentials,
> and `your-heroku-app` with your own Heroku app name.

Note that linking your Heroku app directly to a GitHub repo will not work, as Heroku
cannot resolve git submodules in that case. To work around that limitation, you can
remove the git submodule and start versioning its files as part of this repo, as explained
[here](https://stackoverflow.com/questions/26752481/remove-git-submodule-but-keep-files).
