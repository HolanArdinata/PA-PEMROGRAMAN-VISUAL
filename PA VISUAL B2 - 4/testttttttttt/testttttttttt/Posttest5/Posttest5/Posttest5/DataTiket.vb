Imports System
Imports MySql.Data.MySqlClient

Public Class DataTiket
    Private Sub datatiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampiltiket()
        Call AturGrid()
        Call Kosong()
    End Sub

    Sub Kosong()
        txtkode.Clear()
        txttgl.Clear()
        txtbulan.Text = ""
        txttahun.Text = ""
        txtjam.Text = ""
        txttujuan.Text = ""
        txtkelas.Text = ""
        txtpesawat.Text = ""
        txtharga.Text = ""
        txtkode.Focus()
    End Sub
    Sub AutomaticNumber()
        Call koneksi()
        CMD = New MySqlCommand("Select * from pemesanantiket where kodetiket in (select max(kodetiket) from pemesanantiket)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            UrutanKode = "HLN" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 3) + 1
            UrutanKode = "HLN" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        txtkode.Text = UrutanKode
        RD.Close()
    End Sub
    Sub Tampiltiket()
        QUERY = "select * from tb_tujuan"
        DA = New MySqlDataAdapter(QUERY, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data")

        DataGridView1.DataSource = DS.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Sub AturGrid()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100




        DataGridView1.Columns(0).HeaderText = "KODE TIKET"
        DataGridView1.Columns(1).HeaderText = "TUJUAN"
        DataGridView1.Columns(2).HeaderText = "KELAS"
        DataGridView1.Columns(3).HeaderText = "TANGGAL"
        DataGridView1.Columns(4).HeaderText = "BULAN"
        DataGridView1.Columns(5).HeaderText = "TAHUN"
        DataGridView1.Columns(6).HeaderText = "JAM"
        DataGridView1.Columns(7).HeaderText = "HARGA"
        DataGridView1.Columns(8).HeaderText = "PESAWAT"

    End Sub

    Private Sub txttgl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttgl.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MsgBox("Data yang dimasukkan harus angka!!!")
        End If
    End Sub

    Private Sub txttahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttahun.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus angka!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjam.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9,.]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus angka!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus angka!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txttujuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttujuan.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z, -]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus huruf!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtkelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkelas.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus huruf!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtbulan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbulan.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus huruf!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtpesawat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesawat.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[a-z, A-Z]” _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus huruf!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txttgl.Text = "" Or
           txtkode.Text = "" Or
           txtbulan.Text = "" Or
           txtjam.Text = "" Or
           txtkelas.Text = "" Or
           txttujuan.Text = "" Or
           txttahun.Text = "" Or
           txtpesawat.Text = "" Then
            MsgBox("Data Pemesanan belum lengkap")
            txtkode.Focus()
            Exit Sub
        Else
            CMD = New MySqlCommand("Select * From tb_tujuan where kode ='" & txtkode.Text & "'", CONN)
            RD = CMD.ExecuteReader

            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim Simpan As String = "insert into tb_tujuan (kode,tujuan,kelas,tanggal,bulan,tahun,jam,harga,pesawat) values ('" & txtkode.Text & "','" & txttujuan.Text & "','" & txtkelas.Text & "','" & txttgl.Text & "','" & txtbulan.Text & "' ,'" & txttahun.Text & "','" & txtjam.Text & "','" & txtharga.Text & "','" & txtpesawat.Text & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah",
                           MsgBoxStyle.Information, "Perhatian")
                Tampiltiket()

            End If
            RD.Close()
            txtkode.Focus()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        If txtkode.Text = "" Or txttujuan.Text = "" Or txtkelas.Text = "" Or txtjam.Text = "" Then
            MsgBox("Maaf Data Belum Lengkap..!")

        Else
            CMD = New MySqlCommand
            CMD.Connection = CONN
            QUERY = " update tb_tujuan set kode='" & txtkode.Text & "', tujuan = '" & txttujuan.Text & "', kelas = '" & txtkelas.Text & "', tanggal = '" & txttgl.Text & "', bulan = '" & txtbulan.Text & "', harga = '" & txtharga.Text & "',pesawat = '" & txtpesawat.Text & "' where kode = '" & txtkode.Text & "'"
            CMD.CommandText = QUERY
            CMD.ExecuteNonQuery()
            MsgBox("Update Data Behasil")

        End If
        Tampiltiket()
        RD.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkode.Text = "" Then
            MsgBox("Kode tiket belum diisi")
            txtkode.Focus()
        ElseIf MessageBox.Show("Yakin akan menghapus Data " & txtkode.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CMD = New MySqlCommand("Delete From tb_tujuan Where kode = '" & txtkode.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            Call Kosong()
            Tampiltiket()

        Else
            Call Kosong()
        End If
    End Sub


    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tb_tujuan where tujuan like '%" & txtcari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From tb_tujuan where tujuan like '%" & txtcari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call Kosong()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtkode.Text = DataGridView1.Item(0, i).Value
        txttgl.Text = DataGridView1.Item(3, i).Value
        txtbulan.Text = DataGridView1.Item(4, i).Value
        txttahun.Text = DataGridView1.Item(5, i).Value
        txtjam.Text = DataGridView1.Item(6, i).Value
        txttujuan.Text = DataGridView1.Item(1, i).Value
        txtkelas.Text = DataGridView1.Item(2, i).Value
        txtpesawat.Text = DataGridView1.Item(8, i).Value
        txtharga.Text = DataGridView1.Item(7, i).Value

    End Sub
End Class
