Imports XSploit.Tools
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection.Emit
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace XSploit
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Application.Exit()
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Me.WindowState = FormWindowState.Minimized
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If payload_path.Text <> String.Empty Then

				Dim Extension_Renamed As String = extension.SelectedItem.ToString()

				File.Copy(payload_path.Text,Spoof.Extension(payload_path.Text,Extension_Renamed))

				MessageBox.Show("File Extension Seccessfully Spoofed")
			End If
		End Sub

		Private Sub extension_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles extension.SelectedIndexChanged

		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Using openFileDialog As New OpenFileDialog()
				openFileDialog.InitialDirectory = Environment.CurrentDirectory
				openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*"
				openFileDialog.FilterIndex = 2
				openFileDialog.RestoreDirectory = True
				openFileDialog.CheckFileExists= True

				If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					'Get the path of specified file

					payload_path.Text = openFileDialog.FileName
				End If
			End Using
		End Sub
	End Class
End Namespace
