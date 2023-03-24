Imports System

Namespace XSploit
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.topbar = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.title = New System.Windows.Forms.Label()
            Me.payload_path = New System.Windows.Forms.TextBox()
            Me.extension = New System.Windows.Forms.ComboBox()
            Me.guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
            Me.label3 = New System.Windows.Forms.Label()
            Me.button3 = New System.Windows.Forms.Button()
            Me.topbar.SuspendLayout()
            Me.SuspendLayout()
            '
            'topbar
            '
            Me.topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.topbar.Controls.Add(Me.label2)
            Me.topbar.Controls.Add(Me.button4)
            Me.topbar.Controls.Add(Me.button2)
            Me.topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.topbar.ForeColor = System.Drawing.Color.White
            Me.topbar.Location = New System.Drawing.Point(0, 0)
            Me.topbar.Name = "topbar"
            Me.topbar.Size = New System.Drawing.Size(262, 35)
            Me.topbar.TabIndex = 0
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label2.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.White
            Me.label2.Location = New System.Drawing.Point(12, 9)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(166, 15)
            Me.label2.TabIndex = 4
            Me.label2.Text = "XSploit Edit By MONSTERMC"
            '
            'button4
            '
            Me.button4.BackColor = System.Drawing.Color.RosyBrown
            Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.button4.Dock = System.Windows.Forms.DockStyle.Right
            Me.button4.FlatAppearance.BorderSize = 0
            Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button4.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button4.ForeColor = System.Drawing.Color.Transparent
            Me.button4.Location = New System.Drawing.Point(186, 0)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(38, 35)
            Me.button4.TabIndex = 6
            Me.button4.Text = "-"
            Me.button4.UseVisualStyleBackColor = False
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.Red
            Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.button2.Dock = System.Windows.Forms.DockStyle.Right
            Me.button2.FlatAppearance.BorderSize = 0
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.Transparent
            Me.button2.Location = New System.Drawing.Point(224, 0)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(38, 35)
            Me.button2.TabIndex = 4
            Me.button2.Text = "x"
            Me.button2.UseVisualStyleBackColor = False
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.button1.FlatAppearance.BorderSize = 0
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.Transparent
            Me.button1.Location = New System.Drawing.Point(17, 186)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(161, 43)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Spoof Now"
            Me.button1.UseVisualStyleBackColor = False
            '
            'title
            '
            Me.title.AutoSize = True
            Me.title.BackColor = System.Drawing.Color.Transparent
            Me.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.title.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.title.ForeColor = System.Drawing.Color.White
            Me.title.Location = New System.Drawing.Point(10, 131)
            Me.title.Name = "title"
            Me.title.Size = New System.Drawing.Size(112, 25)
            Me.title.TabIndex = 2
            Me.title.Text = "Extensions:"
            Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'payload_path
            '
            Me.payload_path.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.payload_path.Location = New System.Drawing.Point(82, 85)
            Me.payload_path.Multiline = True
            Me.payload_path.Name = "payload_path"
            Me.payload_path.Size = New System.Drawing.Size(156, 43)
            Me.payload_path.TabIndex = 3
            Me.payload_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'extension
            '
            Me.extension.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.extension.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.extension.FormattingEnabled = True
            Me.extension.Items.AddRange(New Object() {"png", "ico", "pdf", "xls"})
            Me.extension.Location = New System.Drawing.Point(15, 159)
            Me.extension.Name = "extension"
            Me.extension.Size = New System.Drawing.Size(163, 21)
            Me.extension.TabIndex = 4
            '
            'guna2DragControl1
            '
            Me.guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
            Me.guna2DragControl1.TargetControl = Me.topbar
            Me.guna2DragControl1.UseTransparentDrag = True
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.White
            Me.label3.Location = New System.Drawing.Point(77, 57)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(87, 25)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Payload:"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button3
            '
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.button3.FlatAppearance.BorderSize = 0
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button3.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.Transparent
            Me.button3.Location = New System.Drawing.Point(15, 85)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(61, 43)
            Me.button3.TabIndex = 6
            Me.button3.Text = "Select"
            Me.button3.UseVisualStyleBackColor = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Silver
            Me.ClientSize = New System.Drawing.Size(262, 261)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.extension)
            Me.Controls.Add(Me.payload_path)
            Me.Controls.Add(Me.title)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.topbar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "InkSploit"
            Me.topbar.ResumeLayout(False)
            Me.topbar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private topbar As System.Windows.Forms.Panel
		Private WithEvents button1 As System.Windows.Forms.Button
		Private title As System.Windows.Forms.Label
		Private payload_path As System.Windows.Forms.TextBox
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private WithEvents extension As System.Windows.Forms.ComboBox
		Private guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
		Private label3 As System.Windows.Forms.Label
		Private WithEvents button3 As System.Windows.Forms.Button
	End Class
End Namespace

