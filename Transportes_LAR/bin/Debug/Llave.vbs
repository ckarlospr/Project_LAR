Option Explicit
On Error Resume Next
Dim objFSO  
Dim sobreescribir 
Dim W      
sobreescribir = True 
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set W = WScript.CreateObject("WScript.Network")
WScript.sleep 10
If (objFSO.FolderExists(letra("SystemDrive")+"\Users\"+W.UserName+"\Documents\LAR\Debug\")) Then
		If (objFSO.FolderExists("X:\Sistema_LAR\")) Then
			objFSO.CopyFile "X:\Sistema_LAR\Actualizar.vbs", letra("SystemDrive")+"\Users\"+W.UserName+"\Documents\LAR\Debug\", sobreescribir
			Err.Clear
		End If
End If
On Error Goto 0