Imports System.Drawing.Drawing2D

Public Class Form1
	Private Sub BtnGen_Click(sender As Object, e As EventArgs) Handles BtnGen.Click

		Label1.Text = Int(VBMath.Rnd() * 6) + 1
	End Sub
End Class
