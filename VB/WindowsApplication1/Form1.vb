Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Card

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim TempXViewsPrinting As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
		End Sub

		Private Sub cardView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cardView1.KeyDown
			Dim Cards As CardView = TryCast(sender, CardView)
			If e.KeyCode = Keys.Insert AndAlso (Not Cards.IsEditing) Then
				Dim Data As DataView = TryCast(Cards.DataSource, DataView)
				If Data IsNot Nothing Then
					Data.AddNew()
					Cards.FocusedColumn = Cards.GetVisibleColumn(0)
					Cards.ShowEditor()
					e.Handled = True
				End If
			End If
		End Sub

	End Class
End Namespace