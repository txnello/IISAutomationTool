@echo off
:: Verifica se lo script è in esecuzione come amministratore
net session >nul 2>&1
if %errorLevel% neq 0 (
    echo Richiesta elevazione dei privilegi di amministratore...
    :: Riapri il batch come amministratore
    powershell -Command "Start-Process '%~f0' -Verb RunAs"
    exit
)

:: Esegui il comando iisreset
iisreset

:: Attendi 5 secondi prima di chiudere la console
timeout /t 5 /nobreak >nul

:: Chiudi la console
exit
