Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tb_login where namaUser='" & TextUser.Text & "' and passwordUser='" & TextPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Me.Visible = False
            Me.Hide()
            FMenu.Show()
            FMenu.SLabel1.Text = RD.GetString(0)
            FMenu.SLabel2.Text = RD.GetString(1)
            FMenu.SLabel3.Text = RD.GetString(2)
            RD.Close()
            Call Terbuka()

        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextUser.Focus()
            TextUser.Text = ""
            TextPassword.Text = ""
        End If
    End Sub


    Sub Terbuka()
        If TextUser.Text = "Admin" And TextPassword.Text = "Admin" Then
            FMenu.LoginToolStripMenuItem.Enabled = False
            FMenu.LogoutToolStripMenuItem.Enabled = True
            FMenu.MasterDataToolStripMenuItem.Enabled = True
            FMenu.PemesananTiketToolStripMenuItem.Enabled = False
            FMenu.DataTiketToolStripMenuItem.Enabled = True
            FMenu.LaporanToolStripMenuItem.Enabled = True
            FMenu.KeluarToolStripMenuItem.Enabled = True
        Else
            FMenu.LoginToolStripMenuItem.Enabled = False
            FMenu.LogoutToolStripMenuItem.Enabled = True
            FMenu.MasterDataToolStripMenuItem.Enabled = False
            FMenu.PemesananTiketToolStripMenuItem.Enabled = True
            FMenu.DataTiketToolStripMenuItem.Enabled = False
            FMenu.LaporanToolStripMenuItem.Enabled = False
            FMenu.KeluarToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        End
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUser.KeyPress
        If e.KeyChar = Chr(13) Then TextPassword.Focus()
    End Sub

    Private Sub TextPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPassword.KeyPress
        If e.KeyChar = Chr(13) Then ButtonLogin.Focus()
    End Sub
End Class
