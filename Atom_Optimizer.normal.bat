@echo off
:: Run as Administrator

:: Title
title Atom Optimizer V2
echo ===================================
echo     Normal - Atom Optimizer
echo ===================================

:: Disable Reversed Storage (Storage Sense)
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy" /v "01" /t REG_DWORD /d 0 /f >nul 2>&1

:: Disable Hibernation
powercfg -h off >nul 2>&1

:: Disable Telemetry
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\DataCollection" /v "AllowTelemetry" /t REG_DWORD /d 0 /f >nul 2>&1
schtasks /change /tn "\Microsoft\Windows\Customer Experience Improvement Program\Consolidator" /disable >nul 2>&1

:: Disable Location Tracking
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location" /v "Value" /t REG_SZ /d "Deny" /f >nul 2>&1

:: Disable Windows Recall (AI Memory Feature)
reg delete "HKCU\Software\Microsoft\Windows\CurrentVersion\Recall" /f >nul 2>&1

:: Set Non-Essential Services to Manual
sc config SysMain start= demand >nul 2>&1
sc config DiagTrack start= demand >nul 2>&1
sc config dmwappushservice start= demand >nul 2>&1

:: Remove OneDrive
taskkill /f /im OneDrive.exe >nul 2>&1
%SystemRoot%\SysWOW64\OneDriveSetup.exe /uninstall >nul 2>&1
rd "%UserProfile%\OneDrive" /s /q >nul 2>&1

:: Remove Home & Gallery from File Explorer
reg delete "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Home" /f >nul 2>&1
reg delete "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Gallery" /f >nul 2>&1

:: Fully Remove Microsoft Edge
taskkill /f /im msedge.exe >nul 2>&1
rd /s /q "%ProgramFiles(x86)%\Microsoft\Edge" >nul 2>&1
reg delete "HKCU\Software\Microsoft\Edge" /f >nul 2>&1

:: Enable Classic Right-Click Menu
reg add "HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32" /f /ve >nul 2>&1

:: Disable & Fully Remove Windows Copilot
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "ShowCopilotButton" /t REG_DWORD /d 0 /f >nul 2>&1
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\WindowsCopilot" /v "TurnOffWindowsCopilot" /t REG_DWORD /d 1 /f >nul 2>&1
taskkill /f /im Copilot.exe >nul 2>&1
rd /s /q "C:\Program Files\Windows AI" >nul 2>&1
rd /s /q "C:\Windows\SystemApps\Microsoft.Windows.AI.Copilot" >nul 2>&1

:: Remove All Windows Bloatware (Keep Defender, Store, Updates)
for /f "tokens=1 delims=" %%a in ('powershell "Get-AppxPackage | Where-Object {($_.Name -notmatch 'Microsoft.WindowsStore|WindowsDefender|Microsoft.WindowsUpdate')} | Remove-AppxPackage"') do (powershell %%a) >nul 2>&1
for /f "tokens=1 delims=" %%a in ('powershell "Get-AppxProvisionedPackage -Online | Where-Object {($_.PackageName -notmatch 'Microsoft.WindowsStore|WindowsDefender|Microsoft.WindowsUpdate')} | Remove-AppxProvisionedPackage -Online"') do (powershell %%a) >nul 2>&1

:: Remove Xbox Services
sc stop XblAuthManager >nul 2>&1
sc config XblAuthManager start= disabled >nul 2>&1

:: Fully Remove Windows Widgets
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "TaskbarDa" /t REG_DWORD /d 0 /f >nul 2>&1
taskkill /f /im Widgets.exe >nul 2>&1
rd /s /q "C:\Windows\SystemApps\MicrosoftWindows.Client.WebExperience" >nul 2>&1
reg delete "HKCU\Software\Microsoft\Windows\CurrentVersion\Feeds" /f >nul 2>&1

:: Remove Windows Search Icon from Taskbar
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Search" /v "SearchboxTaskbarMode" /t REG_DWORD /d 0 /f >nul 2>&1
taskkill /f /im SearchApp.exe >nul 2>&1
rd /s /q "C:\Windows\SystemApps\Microsoft.Windows.Search" >nul 2>&1

:: Disable Windows Tips & Suggestions
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-338393Enabled" /t REG_DWORD /d 0 /f >nul 2>&1

:: Disable News & Interests on Taskbar
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Feeds" /v "ShellFeedsTaskbarViewMode" /t REG_DWORD /d 2 /f >nul 2>&1

:: Restart Explorer to Apply Changes
taskkill /f /im explorer.exe >nul 2>&1
start explorer.exe >nul 2>&1


echo Finalizing...
echo.
echo Optimization Complete!
exit
