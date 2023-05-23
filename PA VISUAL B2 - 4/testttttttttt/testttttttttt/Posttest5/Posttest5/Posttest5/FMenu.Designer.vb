<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PemesananTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPemesananTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PemesananTiketToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PemesananTiketToolStripMenuItem
        '
        Me.PemesananTiketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesanToolStripMenuItem})
        Me.PemesananTiketToolStripMenuItem.Name = "PemesananTiketToolStripMenuItem"
        Me.PemesananTiketToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.PemesananTiketToolStripMenuItem.Text = "Pemesanan Tiket"
        '
        'PesanToolStripMenuItem
        '
        Me.PesanToolStripMenuItem.Name = "PesanToolStripMenuItem"
        Me.PesanToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.PesanToolStripMenuItem.Text = "Pesan"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataTiketToolStripMenuItem, Me.DataPemesananTiketToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataTiketToolStripMenuItem
        '
        Me.DataTiketToolStripMenuItem.Name = "DataTiketToolStripMenuItem"
        Me.DataTiketToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.DataTiketToolStripMenuItem.Text = "Data Tiket"
        '
        'DataPemesananTiketToolStripMenuItem
        '
        Me.DataPemesananTiketToolStripMenuItem.Name = "DataPemesananTiketToolStripMenuItem"
        Me.DataPemesananTiketToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.DataPemesananTiketToolStripMenuItem.Text = "Data Pemesanan Tiket"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataTiketToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDataTiketToolStripMenuItem
        '
        Me.LaporanDataTiketToolStripMenuItem.Name = "LaporanDataTiketToolStripMenuItem"
        Me.LaporanDataTiketToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.LaporanDataTiketToolStripMenuItem.Text = "Laporan Pemesanan Tiket"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SLabel1, Me.SLabel2, Me.SLabel3, Me.SLabel4, Me.SLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SLabel1
        '
        Me.SLabel1.Name = "SLabel1"
        Me.SLabel1.Size = New System.Drawing.Size(153, 20)
        Me.SLabel1.Text = "ToolStripStatusLabel1"
        '
        'SLabel2
        '
        Me.SLabel2.Name = "SLabel2"
        Me.SLabel2.Size = New System.Drawing.Size(153, 20)
        Me.SLabel2.Text = "ToolStripStatusLabel2"
        '
        'SLabel3
        '
        Me.SLabel3.Name = "SLabel3"
        Me.SLabel3.Size = New System.Drawing.Size(153, 20)
        Me.SLabel3.Text = "ToolStripStatusLabel3"
        '
        'SLabel4
        '
        Me.SLabel4.Name = "SLabel4"
        Me.SLabel4.Size = New System.Drawing.Size(42, 20)
        Me.SLabel4.Text = "Jam :"
        '
        'SLabel5
        '
        Me.SLabel5.Name = "SLabel5"
        Me.SLabel5.Size = New System.Drawing.Size(0, 20)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 59)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MENU TRAVEL JAYA ABADI"
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Posttest5.My.Resources.Resources.back2
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FMenu"
        Me.Text = "FMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SLabel1 As ToolStripStatusLabel
    Friend WithEvents SLabel2 As ToolStripStatusLabel
    Friend WithEvents SLabel3 As ToolStripStatusLabel
    Friend WithEvents DataTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemesananTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SLabel4 As ToolStripStatusLabel
    Friend WithEvents SLabel5 As ToolStripStatusLabel
    Friend WithEvents DataPemesananTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
