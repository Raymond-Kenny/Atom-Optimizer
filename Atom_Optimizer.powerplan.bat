@echo off


:: Title
title Atom Optimizer V2
echo ===================================
echo     PowerPlan - Atom Optimizer V2
echo ===================================
cls
powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61

powercfg.cpl

powercfg -delete 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c
powercfg -delete 381b4222-f694-41f0-9685-ff5bb260df2e
powercfg -delete a1841308-3541-4fab-bc81-f71556f20b4a

echo.
echo Finalizing...
echo.
echo Optimization Complete!
exit
