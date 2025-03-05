@echo off

:: Title
title Atom Optimizer V2
echo ===================================
echo     Adapter - Atom Optimizer V2
echo ===================================
netsh int tcp set global autotuninglevel=auto
netsh int tcp set global ecncapability=enabled
netsh int teredo set state disabled
netsh int isatap set state disable
netsh int ip set global neighborcachelimit=4096
netsh int tcp set global timestamps=disabled
netsh int tcp set heuristics disabled
netsh int tcp set global autotuninglevel=disable
netsh int tcp set global ecncapability=disabled
netsh int tcp set global rss=enabled
netsh int tcp set global rsc=disabled
netsh int tcp set global dca=enabled
netsh int tcp set global netdma=enabled
netsh int tcp set global nonsackrttresiliency=disabled
netsh int tcp set security mpp=disabled
netsh int tcp set security profiles=disabled
netsh int ip set global icmpredirects=disabled
netsh int ip set global multicastforwarding=disabled
netsh int tcp set global ecncapability=enabled
netsh interface teredo set state disabled
netsh interface 6to4 set state disabled
netsh int ip set global icmpredirects=disabled
netsh int ip set global multicastforwarding=disabled
netsh int tcp set supplemental internet congestionprovider=ctcp
netsh int tcp set global autotuninglevel=normal
netsh int tcp set global ecncapability=default
netsh int teredo set state default
netsh int isatap set state default
netsh int ip set global neighborcachelimit=default
netsh int tcp set global timestamps=default
netsh int tcp set heuristics default
netsh int tcp set global autotuninglevel=normal
netsh int tcp set global ecncapability=default
netsh int tcp set global rss=default
netsh int tcp set global rsc=default
netsh int tcp set global dca=default
netsh int tcp set global netdma=default
netsh int tcp set global nonsackrttresiliency=default
netsh int tcp set security mpp=default
netsh int tcp set security profiles=default
netsh int ip set global icmpredirects=default
netsh int ip set global multicastforwarding=default
netsh int tcp set global ecncapability=default
netsh interface teredo set state default
netsh interface 6to4 set state default
netsh int ip set global icmpredirects=default
netsh int ip set global multicastforwarding=default
netsh int tcp set supplemental internet congestionprovider=default

echo.
echo Finalizing...
echo.
echo Optimization Complete!
exit
