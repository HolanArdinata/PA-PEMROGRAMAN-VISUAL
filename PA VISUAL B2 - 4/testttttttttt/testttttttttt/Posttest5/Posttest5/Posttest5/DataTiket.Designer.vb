<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTiket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpesawat = New System.Windows.Forms.TextBox()
        Me.txtjam = New System.Windows.Forms.TextBox()
        Me.txtbulan = New System.Windows.Forms.TextBox()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.txttujuan = New System.Windows.Forms.TextBox()
        Me.txtkelas = New System.Windows.Forms.TextBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txttgl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntambah
        '
        Me.btntambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btntambah.Location = New System.Drawing.Point(577, 143)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(94, 38)
        Me.btntambah.TabIndex = 2
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Location = New System.Drawing.Point(779, 141)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 38)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "Hapus"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnedit.Location = New System.Drawing.Point(687, 142)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 38)
        Me.btnedit.TabIndex = 4
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclear.Location = New System.Drawing.Point(875, 140)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 38)
        Me.btnclear.TabIndex = 5
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(113, -4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(907, 76)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "DATA TIKET TRAVEL JAYA ABADI"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtharga)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtpesawat)
        Me.GroupBox1.Controls.Add(Me.txtjam)
        Me.GroupBox1.Controls.Add(Me.txtbulan)
        Me.GroupBox1.Controls.Add(Me.txttahun)
        Me.GroupBox1.Controls.Add(Me.txttujuan)
        Me.GroupBox1.Controls.Add(Me.txtkelas)
        Me.GroupBox1.Controls.Add(Me.txtcari)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnexit)
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.txttgl)
        Me.GroupBox1.Controls.Add(Me.btntambah)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Banner", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(7, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1121, 244)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[ PEMESANAN TIKET ]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(589, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 24)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Pesawat"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(709, 76)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(197, 29)
        Me.txtharga.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Harga Tiket"
        '
        'txtpesawat
        '
        Me.txtpesawat.Location = New System.Drawing.Point(709, 38)
        Me.txtpesawat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpesawat.Name = "txtpesawat"
        Me.txtpesawat.Size = New System.Drawing.Size(197, 29)
        Me.txtpesawat.TabIndex = 24
        '
        'txtjam
        '
        Me.txtjam.Location = New System.Drawing.Point(163, 196)
        Me.txtjam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjam.Name = "txtjam"
        Me.txtjam.Size = New System.Drawing.Size(135, 29)
        Me.txtjam.TabIndex = 23
        '
        'txtbulan
        '
        Me.txtbulan.Location = New System.Drawing.Point(213, 155)
        Me.txtbulan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbulan.Name = "txtbulan"
        Me.txtbulan.Size = New System.Drawing.Size(227, 29)
        Me.txtbulan.TabIndex = 22
        '
        'txttahun
        '
        Me.txttahun.Location = New System.Drawing.Point(447, 155)
        Me.txttahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.Size = New System.Drawing.Size(60, 29)
        Me.txttahun.TabIndex = 21
        '
        'txttujuan
        '
        Me.txttujuan.Location = New System.Drawing.Point(163, 76)
        Me.txttujuan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttujuan.Name = "txttujuan"
        Me.txttujuan.Size = New System.Drawing.Size(348, 29)
        Me.txttujuan.TabIndex = 20
        '
        'txtkelas
        '
        Me.txtkelas.Location = New System.Drawing.Point(163, 111)
        Me.txtkelas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtkelas.Name = "txtkelas"
        Me.txtkelas.Size = New System.Drawing.Size(135, 29)
        Me.txtkelas.TabIndex = 19
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(577, 204)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(468, 29)
        Me.txtcari.TabIndex = 18
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(163, 33)
        Me.txtkode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(135, 29)
        Me.txtkode.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kode"
        '
        'btnexit
        '
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnexit.Location = New System.Drawing.Point(972, 140)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 38)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txttgl
        '
        Me.txttgl.Location = New System.Drawing.Point(163, 155)
        Me.txttgl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttgl.Name = "txttgl"
        Me.txttgl.Size = New System.Drawing.Size(44, 29)
        Me.txttgl.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kelas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tujuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jam Pemberangkatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tgl. Pemberangkatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 24)
        Me.Label8.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(7, 326)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1121, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(796, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 24)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "CARI"
        '
        'DataTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Posttest5.My.Resources.Resources.back2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1140, 680)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DataTiket"
        Me.Text = "datatiket"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btntambah As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttgl As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtkode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents txtjam As TextBox
    Friend WithEvents txtbulan As TextBox
    Friend WithEvents txttahun As TextBox
    Friend WithEvents txttujuan As TextBox
    Friend WithEvents txtkelas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpesawat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label16 As Label
End Class
