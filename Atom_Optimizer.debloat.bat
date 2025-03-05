@echo off

:: Title
title Atom Optimizer V2
echo ===================================
echo     Debloat - Atom Optimizer V2
echo ===================================

setlocal enabledelayedexpansion

:: Get Edge version
for /f "tokens=2 delims==" %%A in ('wmic datafile where "name='C:\\\\Program Files (x86)\\\\Microsoft\\\\Edge\\\\Application\\\\msedge.exe'" get Version /value ^| find "="') do set EdgeVer=%%A

:: Uninstall Edge
if defined EdgeVer (
    cd /d "C:\Program Files (x86)\Microsoft\Edge\Application\%EdgeVer%\Installer"
    setup.exe --uninstall --system-level --verbose-logging --force-uninstall
)

:: Remove Edge files
rd /s /q "C:\Program Files (x86)\Microsoft\Edge"
rd /s /q "C:\Program Files\Microsoft\Edge"
rd /s /q "C:\Users\%USERNAME%\AppData\Local\Microsoft\Edge"
rd /s /q "C:\Users\%USERNAME%\AppData\Local\Microsoft\EdgeUpdate"

:: Block Edge reinstallation
reg add "HKLM\SOFTWARE\Microsoft\EdgeUpdate" /v "DoNotUpdateToEdgeWithChromium" /t REG_DWORD /d 1 /f >nul 2>&1
reg add "HKLM\SOFTWARE\Policies\Microsoft\EdgeUpdate" /v "AutoUpdateCheckPeriodMinutes" /t REG_DWORD /d 0 /f >nul 2>&1
reg add "HKLM\SOFTWARE\Policies\Microsoft\EdgeUpdate" /v "UpdateDefault" /t REG_DWORD /d 0 /f >nul 2>&1

:: Remove update tasks
takeown /f "C:\Windows\System32\Tasks\Microsoft\EdgeUpdate*" /a /r /d y >nul 2>&1
icacls "C:\Windows\System32\Tasks\Microsoft\EdgeUpdate*" /inheritance:r /grant:r Administrators:F /t /c >nul 2>&1
del /f /q "C:\Windows\System32\Tasks\Microsoft\EdgeUpdate*" >nul 2>&1

:: Block Edge system files
takeown /f "C:\Windows\System32\MicrosoftEdge*" /a /r /d y >nul 2>&1
icacls "C:\Windows\System32\MicrosoftEdge*" /inheritance:r /grant:r Administrators:F /t /c >nul 2>&1
rd /s /q "C:\Windows\System32\MicrosoftEdge" >nul 2>&1

:: Disable Edge services
sc config edgeupdate start= disabled >nul 2>&1
sc config edgeupdatem start= disabled >nul 2>&1
sc stop edgeupdate >nul 2>&1
sc stop edgeupdatem >nul 2>&1


reg delete HKCR\Extensions\ContractId\Windows.Search\PackageId\Microsoft.Windows.Search_1.14.0.19041_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.ComponentUI\PackageId\Microsoft.Windows.Search_1.14.0.19041_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.ComponentUI\PackageId\Microsoft.Windows.StartMenuExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.AppService\PackageId\Microsoft.Windows.Search_1.14.0.19041_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.AppService\PackageId\Microsoft.Windows.ShellExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.Windows.Search_1.14.0.19041_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.Windows.ShellExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.ShareTarget\PackageId\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0 /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\46928bounde.EclipseManager_2.2.4.51_neutral__a5h4egax66k6y /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0 /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.MicrosoftOfficeHub_17.7909.7600.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.PPIProjection_10.0.15063.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.XboxGameCallableUI_1000.15063.0.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.XboxGameCallableUI_1000.16299.15.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.Windows.Search_1.14.0.19041_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.Windows.ShellExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\Microsoft.Windows.StartMenuExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.BackgroundTasks\PackageId\MicrosoftWindows.UndockedDevKit_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.File\PackageId\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0 /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\46928bounde.EclipseManager_2.2.4.51_neutral__a5h4egax66k6y /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0 /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\Microsoft.PPIProjection_10.0.15063.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\Microsoft.XboxGameCallableUI_1000.15063.0.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\Microsoft.XboxGameCallableUI_1000.16299.15.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\Microsoft.Windows.Search_1.14.0.19041_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\Microsoft.Windows.ShellExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\Microsoft.Windows.StartMenuExperienceHost_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Launch\PackageId\MicrosoftWindows.UndockedDevKit_10.0.19041.423_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.PreInstalledConfigTask\PackageId\Microsoft.MicrosoftOfficeHub_17.7909.7600.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0 /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.PPIProjection_10.0.15063.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxGameCallableUI_1000.15063.0.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxGameCallableUI_1000.16299.15.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.BingWeather_4.25.20211.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.GetHelp_10.1706.13331.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.Getstarted_8.2.22942.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.MicrosoftEdge_44.19041.423.0_neutral__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.MicrosoftOfficeHub_18.1903.1152.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.MixedReality.Portal_2000.19081.1301.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.MSPaint_6.1907.29027.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.Office.OneNote_16001.12026.20112.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.People_10.1902.633.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.WindowsAlarms_10.1906.2182.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.WindowsCamera_2018.826.98.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.WindowsFeedbackHub_1.1907.3152.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.WindowsCalculator_10.1906.55.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.WindowsMaps_5.1906.1972.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.WindowsStore_11910.1002.5.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.Xbox.TCUI_1.23.28002.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxApp_48.49.31001.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxGameCallableUI_1000.19041.423.0_neutral_neutral_cw5n1h2txyewy /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxGameOverlay_1.46.11001.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxGamingOverlay_2.34.28001.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.XboxSpeechToTextOverlay_1.17.29001.0_x64__8wekyb3d8bbwe /f
reg delete HKCR\Extensions\ContractId\Windows.Protocol\PackageId\Microsoft.ZuneMusic_10.19071.19011.0_x64__8wekyb3d8bbwe /f
cls
PowerShell -Command "Get-AppxPackage *3dbuilder* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *officehub* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *skypeapp* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Messaging* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *ConnectivityStore* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *bingnews* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Office.Sway* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.Microsoft3DViewer* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *windowsalarms* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *bingsports* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *windowscalculator* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *windowscommunicationsapps* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.549981C3F5F10* | Remove-AppxPackage"
PowerShell -Command "Get-appxpackage *feedback* | remove-appxpackage"
PowerShell -Command "Get-AppxPackage *Microsoft.GetHelp* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *getstarted* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.HEIFImageExtension* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *windowsmaps* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.Messaging* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.MixedReality.Portal* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.OneConnect* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *bingfinance* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.MSPaint* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *people* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *windowsphone* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.YourPhone* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.Print3D* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.ScreenSketch* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.MicrosoftStickyNotes* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *soundrecorder* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.WebMediaExtensions* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.WebpImageExtension* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *xboxapp* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.XboxGamingOverlay* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Microsoft.XboxSpeechToTextOverlay* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *Print3d* | Remove-AppxPackage"
Get-AppxPackage *3Dviewer* | Remove-AppxPackage
Get-AppxPackage *Minecraft* | Remove-AppxPackage
Get-AppxPackage *Bing* | Remove-AppxPackage
Get-AppxPackage *Skype* | Remove-AppxPackage
Get-AppxPackage *Solitaire* | Remove-AppxPackage
Get-AppxPackage *Candycrush* | Remove-AppxPackage
Get-AppxPackage *Netflix* | Remove-AppxPackage
Get-AppxPackage *Onenote* | Remove-AppxPackage
Get-AppxPackage *Dolby* | Remove-AppxPackage
Get-AppxPackage *Fitbit* | Remove-AppxPackage
Get-AppxPackage *Feedback* | Remove-AppxPackage
Get-AppxPackage *Yourphone* | Remove-AppxPackage
cls
PowerShell -Command "Get-AppxPackage *Microsoft.3DBuilder* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.Print3D* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.Microsoft3DViewer* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.WindowsAlarms* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.BingNews* | Remove-AppxPackage" && cls  
PowerShell -Command "Get-AppxPackage *Microsoft.WindowsCalculator* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.WindowsCamera* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.549981C3F5F10* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.WindowsFeedbackHub* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.GetHelp* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.Getstarted* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.WindowsMaps* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.Messaging* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.Advertising.Xaml* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.Advertising.Xaml_10.1712.5.0_x64__8wekyb3d8bbwe* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.Advertising.Xaml_10.1712.5.0_x86__8wekyb3d8bbwe* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.MicrosoftEdge.Stable* | Remove-AppxPackage" && cd %PROGRAMFILES(X86)%\Microsoft\Edge\Application\8*\Installer && setup --uninstall --force-uninstall --system-level && cls
PowerShell -Command "Get-AppxPackage *Microsoft.MicrosoftOfficeHub* | Remove-AppxPackage"  > nul && PowerShell -Command "Get-AppxPackage *Microsoft.Office.Sway* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.Office.Desktop* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *microsoft.windowscommunicationsapps* | Remove-AppxPackage"  && cls
PowerShell -Command "Get-AppxPackage *Microsoft.MixedReality.Portal* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.Wallet* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.People* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.Office.OneNote* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.MicrosoftSolitaireCollection* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.MicrosoftStickyNotes* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.RemoteDesktop* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.WindowsSoundRecorder* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.BingWeather* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.XboxApp* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage -AllUsers *Microsoft.XboxGamingOverlay* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.Xbox.TCUI* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.XboxGameOverlay* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.XboxIdentityProvider* | Remove-AppxPackage" && PowerShell -Command "Get-AppxPackage *Microsoft.XboxSpeechToTextOverlay* | Remove-AppxPackage" && reg delete "HKEY_CURRENT_USER\System\GameConfigStore\Parents" /f  > nul && reg delete "HKEY_CURRENT_USER\System\GameConfigStore\Children" /f  > nul && cls
PowerShell -Command "Get-AppxPackage *Microsoft.YourPhone* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *AdobeSystemsIncorporated.AdobePhotoshopExpress* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *CandyCrush* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Duolingo-LearnLanguagesforFree* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Facebook* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Flipboard* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *7EE7776C.LinkedInforWindows* | Remove-AppxPackage" && cls
%SystemRoot%\SysWOW64\OneDriveSetup.exe /uninstall  > nul && %SystemRoot%\System32\OneDriveSetup.exe /uninstall  > nul && cls
PowerShell -Command "Get-AppxPackage *Mirkat.Mirkat* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Microsoft.NetworkSpeedTest* | Remove-AppxPackage" && cls
PowerShell -Command "Get-AppxPackage *Spotify* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *RealtekSemiconductorCorp.RealtekAudioControl* | Remove-AppxPackage" && cls 
PowerShell -Command "Get-AppxPackage *Microsoft.SkypeApp* | Remove-AppxPackage" && cls 
cls
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo Finalizing...
echo.
echo Optimization Complete!
exit
