<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		BtnGen = New Button()
		Label1 = New Label()
		Label2 = New Label()
		SuspendLayout()
		' 
		' BtnGen
		' 
		BtnGen.BackColor = SystemColors.ActiveCaption
		BtnGen.Location = New Point(301, 355)
		BtnGen.Name = "BtnGen"
		BtnGen.Size = New Size(112, 34)
		BtnGen.TabIndex = 0
		BtnGen.Text = "Generate"
		BtnGen.UseVisualStyleBackColor = False
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = SystemColors.ActiveBorder
		Label1.Font = New Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point)
		Label1.Location = New Point(276, 133)
		Label1.Name = "Label1"
		Label1.Size = New Size(166, 191)
		Label1.TabIndex = 1
		Label1.Text = "6"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Showcard Gothic", 14F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
		Label2.Location = New Point(92, 57)
		Label2.Name = "Label2"
		Label2.Size = New Size(475, 35)
		Label2.TabIndex = 2
		Label2.Text = "Generating Random Integers"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ControlDark
		ClientSize = New Size(800, 450)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(BtnGen)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents BtnGen As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
