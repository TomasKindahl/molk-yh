# MUD (Avaloniaversionen)

```
dotnet new avalonia.app -o dtp8_MUD_ava
cd dtp8_MUD_ava
dotnet run
git init
git branch -M main
git remote add origin git@github.com:TomasKindahl/dtp8_MUD_ava.git
git config pull.rebase false
git pull origin main
```
: \# rm everything that needs to be removed:
```
rm .gitignore App.axaml* MainWindow.axaml* Program.cs dtp8_MUD_ava.csproj
git pull origin main
```
