Set objDisco = CreateObject("Scripting.FileSystemObject")
Set objRed = WScript.CreateObject("WScript.Network")

on error resume next
objRed.MapNetworkDrive "X:", "\\192.168.0.198\SERVERLINUX", true, "root", "Admin12.3"