## Updating the Frontend Submodule

```bash
cd wwwroot
git checkout master
git pull
cd ..
```

## Removing the Frontend Submodule

If you want to remove the git submodule, and start tracking its files
as part of this repository:

```bash
git rm --cached wwwroot
git rm .gitmodules
rm -rf wwwroot/.git
git add wwwroot
```
