@echo off

REM مسیر فایل مبدا
set source=HealthReminder.exe

REM
set destination=%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup

REM
if not exist %source% (
    echo Source file not found.: %source%
    pause
    exit /b
)

REM
xcopy /y "%source%" "%destination%"

REM
if exist "%destination%\HealthReminder.exe" (
    echo The file was successfully auto-run.
) else (
    echo File transfer failed.
)

pause
