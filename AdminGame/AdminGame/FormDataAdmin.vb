Imports System.Data.SqlClient
Public Class FormDataAdmin

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.AdidotsDataSet)

    End Sub

    Private Sub FormDataAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AdminTableAdapter.Fill(Me.AdidotsDataSet.admin)
    End Sub
End Class