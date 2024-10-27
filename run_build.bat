@echo off

chcp 65001 >nul

set "modName=BetterRecipes"
set "reposPath=G:\Programming IDEs\repos\C#\Modding\COI\CoI BetterRecipes Mod"
set "reposBasePath=G:\Programming IDEs\repos\C#\Modding\COI"

set "targetFolder=C:\Users\thoma\AppData\Roaming\Captain of Industry\Mods\%modName%\"
set "sourceFile=%reposPath%\bin\Release\net472\%modName%.dll"
set "projectFilePath=%reposPath%\%modName%.csproj"
set "startGamePath=%reposPath%\Captain of Industry.url"
set "targetFolder_AS=%targetFolder%AssetBundles\"
set "sourceFolder_AS=%reposBasePath%\Captain-of-industry-modding\src\ExampleMod.Unity\AssetBundles\"

if not exist "%targetFolder%" (
    mkdir "%targetFolder%"
)
if not exist "%targetFolder_AS%" (
    mkdir "%targetFolder_AS%"
)

:loop

cls

echo Building project...
dotnet build "%projectFilePath%" -c Release /p:LangVersion=10.0

if %errorlevel% equ 0 (
    echo Build successful, copying .dll file...
    xcopy /d /y "%sourceFile%" "%targetFolder%"    
    if %errorlevel% equ 0 (
	echo.
        echo Checking for new mod files successful.
        xcopy /d /e /y "%sourceFolder_AS%\*" "%targetFolder_AS%\"
        
        if %errorlevel% equ 0 (
            echo.
            echo Start game...
            rem Start game
            start "" "%startGamePath%"

        ) else (
            echo.
            echo Checking for new assets failed!
        )
    ) else (
	echo.
        echo Checking for new mod files failed!
    )
) else (
    echo.
    echo Build failed!
)
echo.
pause
cls
goto loop




