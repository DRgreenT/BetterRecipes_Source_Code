@echo off

set "modName=BetterRecipes"
set "targetFolder=%COI_MOD_ROOT%%modName%\"
set "sourceFile=%REPOS_ROOT%CoI %modName% Mod\bin\Debug\net472\publish\%modName%.dll"
set "projectFilePath=%REPOS_ROOT%CoI %modName% Mod\%modName%.csproj"
set "startGamePath=%REPOS_ROOT%CoI %modName% Mod\Captain of Industry.url"


if not exist "%targetFolder%" (
    mkdir "%targetFolder%"
)

:loop

cls
echo "%COI_MOD_ROOT%
dotnet publish "%projectFilePath%" /p:LangVersion=10.0
if %errorlevel% equ 0 (
    copy /y "%sourceFile%" "%targetFolder%"
    if %errorlevel% equ 0 (
        echo Datei erfolgreich kopiert.
        start "" "%startGamePath%"
    ) else (
        echo Kopieren fehlgeschlagen.
    )
) else (
    echo Build-Vorgang fehlgeschlagen.
)

pause
goto loop
