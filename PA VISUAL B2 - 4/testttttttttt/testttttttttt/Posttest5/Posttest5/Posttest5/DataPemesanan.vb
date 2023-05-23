Imports MySql.Data.MySqlClient

Public Class DataPemesanan
    Private Sub DataPemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AutomaticNumber()
        Call Kosong()
        Call Tampiltiket()
    End Sub

    Sub Kosong()
        cbkodetujuan.Text = ""
        cbpembayaran.Text = ""
        txtkode.Clear()
        txtnama.Clear()
        txttelepon.Clear()
        txttgl.Clear()
        txtbulan.Clear()
        txttahun.Clear()
        txtjam.Clear()
        txttujuan.Clear()
        txtkelas.Clear()
        txtharga.Clear()
        txtpesawat.Clear()
        txtjumlah.Clear()
        txttahun.Clear()
        jml.Text = ""
        nama.Text = ""
        telepon.Text = ""
        tgl.Text = ""
        bulan.Text = ""
        tahun.Text = ""
        tujuan.Text = ""
        jam.Text = ""
        pesawat.Text = ""
        kelas.Text = ""
        harga.Text = ""
        pembayaran.Text = ""
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


    'Sub AturGrid()
    '    DataGridView1.Columns(0).Width = 50
    '    DataGridView1.Columns(1).Width = 50
    '    DataGridView1.Columns(2).Width = 50
    '    DataGridView1.Columns(3).Width = 100
    '    DataGridView1.Columns(4).Width = 100
    '    DataGridView1.Columns(5).Width = 100
    '    DataGridView1.Columns(6).Width = 100
    '    DataGridView1.Columns(7).Width = 100
    '    DataGridView1.Columns(8).Width = 100
    '    DataGridView1.Columns(9).Width = 100
    '    DataGridView1.Columns(10).Width = 100
    '    DataGridView1.Columns(11).Width = 100
    '    DataGridView1.Columns(12).Width = 100

    '    DataGridView1.Columns(0).HeaderText = "KODE"
    '    DataGridView1.Columns(1).HeaderText = "KODE TUJUAN"
    '    DataGridView1.Columns(2).HeaderText = "NAMA"
    '    DataGridView1.Columns(3).HeaderText = "TELEPON"
    '    DataGridView1.Columns(4).HeaderText = "TANGGAL"
    '    DataGridView1.Columns(5).HeaderText = "BULAN"
    '    DataGridView1.Columns(6).HeaderText = "TAHUN"
    '    DataGridView1.Columns(7).HeaderText = "JAM"
    '    DataGridView1.Columns(8).HeaderText = "TUJUAN"
    '    DataGridView1.Columns(9).HeaderText = "KELAS"
    '    DataGridView1.Columns(10).HeaderText = "JUMLAH TIKET"
    '    DataGridView1.Columns(11).HeaderText = "HARGA TIKET"
    '    DataGridView1.Columns(12).HeaderText = "PEMBAYARAN"

    'End Sub
    Sub Tampiltiket()
        QUERY = "select * from pemesanantiket"
        DA = New MySqlDataAdapter(QUERY, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "data")

        DataGridView1.DataSource = DS.Tables("data")
        DataGridView1.Refresh()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        If txtnama.Text = "" Or
           txttelepon.Text = "" Or
           txtjumlah.Text = "" Or
           txttgl.Text = "" Or
           cbkodetujuan.Text = "" Or
           cbpembayaran.Text = "" Or
           txtjam.Text = "" Or
           txtkelas.Text = "" Or
           txttujuan.Text = "" Or
           txttahun.Text = "" Or
           txtpesawat.Text = "" Or
           txtharga.Text = "" Then
            MsgBox("Data Pemesanan belum lengkap")
            txtnama.Focus()
            Exit Sub


        Else
            CMD = New MySqlCommand("Select * From pemesanantiket where kodetiket ='" & txtkode.Text & "'", CONN)
            RD = CMD.ExecuteReader

            RD.Read()
            If Not RD.HasRows Then
                Dim harga, jumlah, total As Double
                jumlah = Val(Me.txtjumlah.Text)
                harga = Val(Me.txtharga.Text)


                total = jumlah * harga

                Me.total.Text = total
                Me.txttotal.Text = total
                Me.jml.Text = jumlah
                Me.nama.Text = txtnama.Text
                Me.telepon.Text = txttelepon.Text
                Me.tgl.Text = txttgl.Text
                Me.bulan.Text = txtbulan.Text
                Me.tahun.Text = txttahun.Text
                Me.tujuan.Text = txttujuan.Text
                Me.jam.Text = txtjam.Text
                Me.pesawat.Text = txtpesawat.Text
                Me.kelas.Text = txtkelas.Text
                Me.harga.Text = txtharga.Text
                Me.pembayaran.Text = cbpembayaran.Text
                Me.harga.Text = Format(harga, "Rp ###,###")
                Me.total.Text = Format(total, "Rp ###,###")


                RD.Close()
                Dim Simpan As String = "insert into pemesanantiket (kodetiket,kodetujuan,nama,telepon,tanggal,bulan,tahun,jam,pesawat,tujuan,kelas,jumlah,harga,pembayaran) values ('" & txtkode.Text & "','" & cbkodetujuan.Text & "','" & txtnama.Text & "','" & txttelepon.Text & "','" & txttgl.Text & "','" & txtbulan.Text & "' ,'" & txttahun.Text & "','" & txtjam.Text & "','" & txtpesawat.Text & "','" & txttujuan.Text & "','" & txtkelas.Text & "','" & txtjumlah.Text & "','" & txttotal.Text & "','" & cbpembayaran.Text & "')"
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


    Private Sub txttelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelepon.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MsgBox("Data yang dimasukkan harus angka!!!")
        End If
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[1-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            MsgBox("Data yang dimasukkan harus angka!!!")
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnama.KeyPress
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

    Private Sub cbkodetujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkodetujuan.SelectedIndexChanged
        CMD = New MySqlCommand("Select * From tb_tujuan where kode='" & cbkodetujuan.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = True Then
            txttgl.Text = RD.Item(3)
            txtbulan.Text = RD.Item(4)
            txttahun.Text = RD.Item(5)
            txtjam.Text = RD.Item(6)
            txttujuan.Text = RD.Item(1)
            txtkelas.Text = RD.Item(2)
            txtharga.Text = RD.Item(7)
            txtpesawat.Text = RD.Item(8)

        Else
            MsgBox("Kode tujuan ini Tidak Terdaftar")
        End If
        RD.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtnama.Text = "" Or
           txttelepon.Text = "" Or
           txtjumlah.Text = "" Or
           txttgl.Text = "" Or
           cbkodetujuan.Text = "" Or
           cbpembayaran.Text = "" Or
           txtjam.Text = "" Or
           txtkelas.Text = "" Or
           txttujuan.Text = "" Or
           txttahun.Text = "" Or
           txtpesawat.Text = "" Or
           txtharga.Text = "" Then
            MsgBox("Data Pemesanan belum lengkap")
            txtnama.Focus()
            Exit Sub


        Else
            Dim harga, jumlah, total As Double
            jumlah = Val(Me.txtjumlah.Text)
            harga = Val(Me.txtharga.Text)


            total = jumlah * harga

            Me.total.Text = total
            Me.txttotal.Text = total
            Me.jml.Text = jumlah
            Me.nama.Text = txtnama.Text
            Me.telepon.Text = txttelepon.Text
            Me.tgl.Text = txttgl.Text
            Me.bulan.Text = txtbulan.Text
            Me.tahun.Text = txttahun.Text
            Me.tujuan.Text = txttujuan.Text
            Me.jam.Text = txtjam.Text
            Me.pesawat.Text = txtpesawat.Text
            Me.kelas.Text = txtkelas.Text
            Me.harga.Text = txtharga.Text
            Me.pembayaran.Text = cbpembayaran.Text
            Me.harga.Text = Format(harga, "Rp ###,###")
            Me.total.Text = Format(total, "Rp ###,###")



            CMD = New MySqlCommand
            CMD.Connection = CONN
            QUERY = "UPDATE pemesanantiket SET kodetiket='" & txtkode.Text & "', kodetujuan = '" & cbkodetujuan.Text & "', nama = '" & txtnama.Text & "', telepon = '" & txttelepon.Text & "', tanggal = '" & txttgl.Text & "', bulan = '" & txtbulan.Text & "', jumlah = '" & txttahun.Text & "', jam = '" & txtjam.Text & "', pesawat = '" & txtpesawat.Text & "', tujuan = '" & txttujuan.Text & "', kelas = '" & txtkelas.Text & "', jumlah = '" & txtjumlah.Text & "', harga = '" & txttotal.Text & "', pembayaran = '" & cbpembayaran.Text & "' WHERE kodetiket = '" & txtkode.Text & "'"
            CMD.CommandText = QUERY
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil diubah", vbInformation, "Pemberitahuan")
            Tampiltiket()
            RD.Close()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Kosong()
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtkode.Text = "" Then
            MsgBox("Kode tiket belum diisi")
            txtkode.Focus()
        ElseIf MessageBox.Show("Yakin akan menghapus Data " & txtkode.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            CMD = New MySqlCommand("Delete From pemesanantiket Where kodetiket = '" & txtkode.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            Call Kosong()
            Tampiltiket()

        Else
            Call Kosong()
        End If
    End Sub




    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From pemesanantiket where nama like '%" & txtcari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * From pemesanantiket where nama like '%" & txtcari.Text & "%'", CONN)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtkode.Text = DataGridView1.Item(0, i).Value
        txtnama.Text = DataGridView1.Item(2, i).Value
        txttelepon.Text = DataGridView1.Item(3, i).Value
        txttgl.Text = DataGridView1.Item(4, i).Value
        txtbulan.Text = DataGridView1.Item(5, i).Value
        txttahun.Text = DataGridView1.Item(6, i).Value
        txtjam.Text = DataGridView1.Item(7, i).Value
        txtpesawat.Text = DataGridView1.Item(8, i).Value
        cbkodetujuan.Text = DataGridView1.Item(1, i).Value
        txttujuan.Text = DataGridView1.Item(9, i).Value
        txtkelas.Text = DataGridView1.Item(10, i).Value
        txtjumlah.Text = DataGridView1.Item(11, i).Value
        txtharga.Text = DataGridView1.Item(12, i).Value
        cbpembayaran.Text = DataGridView1.Item(13, i).Value


    End Sub


End Class