On Error Resume Next
Dim objFSO  
Dim sobreescribir 
Dim W    
Dim WshShell, Link  
sobreescribir = True 
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set W = WScript.CreateObject("WScript.Network")
Set WshShell = WScript.CreateObject("WScript.Shell")
Set letra = WshShell.Environment("Process")
Set Link = WshShell.CreateShortcut(letra("SystemDrive")+"\Users\"+W.UserName+"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\Transportes_LAR.lnk")
With Link
   .TargetPath = letra("SystemDrive")+"\Users\"+W.UserName+"\Dropbox\LAR\Debug\Transportes_LAR.exe"   'Archivo al cual vamos a vincular
   .WindowStyle = 1         'tipo de inicio, [Normal, Maximizado, Minimizado]
   .Hotkey = "CTRL+SHIFT+E"      'HotKey
   .IconLocation = "explorer.exe, 0"   'Localización del Icono
   .Description = "Acceso directo"      'Descripción del acceso directo
   .WorkingDirectory = letra("SystemDrive")+"\Users\"+W.UserName+"\Dropbox\LAR\Debug\"      'Directorio de trabajo
   .Save               '[Guardar todo / Crear el acceso directo]
End With
On Error Goto 0