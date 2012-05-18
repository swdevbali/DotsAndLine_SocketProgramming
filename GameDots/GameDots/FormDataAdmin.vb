Public Class FormDataAdmin

    Private Sub AdminBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdidotsDataSet)

    End Sub


    Private Sub FormDataAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdidotsDataSet.admin' table. You can move, or remove it, as needed.

        Me.AdminTableAdapter.Fill(Me.AdidotsDataSet.admin)

    End Sub


End Class