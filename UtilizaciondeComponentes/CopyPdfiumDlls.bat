@echo off
echo Copiando bibliotecas nativas de PdfiumViewer...

REM Crear directorios específicos para arquitectura si no existen
if not exist "%~dp0bin\Debug\x64" mkdir "%~dp0bin\Debug\x64"
if not exist "%~dp0bin\Debug\x86" mkdir "%~dp0bin\Debug\x86"

REM Copiar la DLL de 64 bits desde los paquetes a la carpeta x64
echo Copiando pdfium.dll de 64 bits...
set X64_SOURCE="%~dp0..\packages\PdfiumViewer.Native.x86_64.v8-xfa.2018.4.8.256\Build\x64\pdfium.dll"
set X64_DEST="%~dp0bin\Debug\x64\pdfium.dll"

if exist %X64_SOURCE% (
    copy /Y %X64_SOURCE% %X64_DEST%
) else (
    echo ERROR: No se pudo encontrar pdfium.dll de 64 bits en %X64_SOURCE%
    
    REM Intentar buscar en ubicaciones alternativas
    for /d %%i in ("%~dp0..\packages\PdfiumViewer.Native.x86_64*") do (
        if exist "%%i\Build\x64\pdfium.dll" (
            echo Encontrado en ubicación alternativa: %%i\Build\x64\pdfium.dll
            copy /Y "%%i\Build\x64\pdfium.dll" %X64_DEST%
            goto found_x64
        )
        
        if exist "%%i\x64\pdfium.dll" (
            echo Encontrado en ubicación alternativa: %%i\x64\pdfium.dll
            copy /Y "%%i\x64\pdfium.dll" %X64_DEST%
            goto found_x64
        )
    )
    
    echo No se pudo encontrar pdfium.dll de 64 bits en ninguna ubicación
    goto check_x86
    
    :found_x64
    echo Copiado correctamente
)

:check_x86
REM Copiar la DLL de 32 bits desde los paquetes a la carpeta x86
echo Copiando pdfium.dll de 32 bits...
set X86_SOURCE="%~dp0..\packages\PdfiumViewer.Native.x86.v8-xfa.2018.4.8.256\Build\x86\pdfium.dll"
set X86_DEST="%~dp0bin\Debug\x86\pdfium.dll"

if exist %X86_SOURCE% (
    copy /Y %X86_SOURCE% %X86_DEST%
) else (
    echo ERROR: No se pudo encontrar pdfium.dll de 32 bits en %X86_SOURCE%
    
    REM Intentar buscar en ubicaciones alternativas
    for /d %%i in ("%~dp0..\packages\PdfiumViewer.Native.x86*") do (
        if exist "%%i\Build\x86\pdfium.dll" (
            echo Encontrado en ubicación alternativa: %%i\Build\x86\pdfium.dll
            copy /Y "%%i\Build\x86\pdfium.dll" %X86_DEST%
            goto found_x86
        )
        
        if exist "%%i\x86\pdfium.dll" (
            echo Encontrado en ubicación alternativa: %%i\x86\pdfium.dll
            copy /Y "%%i\x86\pdfium.dll" %X86_DEST%
            goto found_x86
        )
    )
    
    echo No se pudo encontrar pdfium.dll de 32 bits en ninguna ubicación
    goto end
    
    :found_x86
    echo Copiado correctamente
)

:end
REM También copiar a la raíz del directorio bin para compatibilidad
echo Copiando biblioteca nativa al directorio raíz para compatibilidad...

REM Determinar plataforma para decidir qué versión copiar a la raíz
REM Preferimos la versión de 64 bits si estamos en la plataforma x64
if exist %X64_DEST% (
    if "%PROCESSOR_ARCHITECTURE%"=="AMD64" (
        echo Copiando versión x64 al directorio raíz
        copy /Y %X64_DEST% "%~dp0bin\Debug\pdfium.dll"
    ) else (
        echo Copiando versión x86 al directorio raíz (sistema de 32 bits)
        if exist %X86_DEST% (
            copy /Y %X86_DEST% "%~dp0bin\Debug\pdfium.dll"
        ) else (
            echo No hay versión x86 disponible para copiar
        )
    )
) else (
    if exist %X86_DEST% (
        echo Copiando versión x86 al directorio raíz (versión x64 no disponible)
        copy /Y %X86_DEST% "%~dp0bin\Debug\pdfium.dll"
    ) else (
        echo ADVERTENCIA: No se pudieron encontrar versiones de pdfium.dll para copiar al directorio raíz
    )
)

echo Copia de bibliotecas nativas de PdfiumViewer completada
