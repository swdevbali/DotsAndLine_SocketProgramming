Public Class FormDataPemain

    Private Sub PemainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemainBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.PemainBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdidotsDataSet)

    End Sub


    Private Sub FormDataPemain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdidotsDataSet.pemain' table. You can move, or remove it, as needed.

        Me.PemainTableAdapter.Fill(Me.AdidotsDataSet.pemain)

    End Sub

End Class