!define /date MyTIMESTAMP "%Y-%m-%d@%H-%M"
Name "Alea ${MyTIMESTAMP}"
OutFile "Alea_Release_Setup-${MyTIMESTAMP}.exe"

InstallDir "$DESKTOP\Alea"

RequestExecutionLevel user

Page Directory
Page Instfiles
;--------------------------------
Section "Files" 
  CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r "Binary\Release\*.dll"
  File /r "Binary\Release\*.exe"
SectionEnd ; end the section
