﻿Public Class FormMenuAdmin

    Private Sub btnDataAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataAdmin.Click
        FormDataAdmin.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        FormMenuLogin.Show()
        Me.Dispose()
        'Application.Exit()
    End Sub

    Private Sub btnDataPemain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDataPemain.Click

        FormDataPemain.Show()
    End Sub

    Private Sub FormMenuAdmin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

 
    Private Sub FormMenuAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'instanceFormLobiGame.Timer1.Enabled = False
    End Sub
End Class