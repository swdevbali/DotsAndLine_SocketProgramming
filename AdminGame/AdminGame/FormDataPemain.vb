Imports System.Data.SqlClient
Public Class FormDataPemain
    Dim MyConnection As New KoneksiDb
    Dim objConnection As SqlConnection
    Dim objCommand As SqlCommand
    Dim objDataAdapter As SqlDataAdapter
    Dim objdatareader As SqlDataReader
    Dim strSQL As String
    Dim objDataSet As New DataSet
    Dim objDataTable As New DataTable
    Public mProcess As String
    Dim mPosition As Integer

    Private Sub FormDataPemain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PemainTableAdapter.Fill(Me.AdidotsDataSet.pemain)
    End Sub


    Private Sub PemainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemainBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PemainBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdidotsDataSet)

    End Sub
End Class