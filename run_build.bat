@echo off
setlocal

set "targetFolder=C:\Users\thoma\AppData\Roaming\Captain of Industry\Mods\BetterRecipes"
set "sourceFile=G:\Programming IDEs\repos\CoI BetterRecipes Mod\bin\Debug\net472\publish\BetterRecipes.dll"
set "projectFilePath=G:\Programming IDEs\repos\CoI BetterRecipes Mod\BetterRecipes.csproj"
set "startGamePath=C:\Users\thoma\Desktop\Captain of Industry.url"

if not exist "%targetFolder%" (
    mkdir "%targetFolder%"
)

:loop

cls

dotnet publish "%projectFilePath%" /p:LangVersion=10.0
if %errorlevel% equ 0 (
    copy /y "%sourceFile%" "%targetFolder%"
    if %errorlevel% equ 0 (
        echo Datei erfolgreich kopiert.
        rem Hier kannst du eine Aktion ausführen, z.B. eine Datei öffnen
        start "" "%startGamePath%"
    ) else (
        echo Kopieren fehlgeschlagen.
    )
) else (
    echo Build-Vorgang fehlgeschlagen.
)

pause
goto loop
