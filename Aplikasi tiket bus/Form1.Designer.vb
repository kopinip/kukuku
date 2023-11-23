<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        cbkelas = New ComboBox()
        cbtujuan = New ComboBox()
        cbjam = New ComboBox()
        cbtahun = New ComboBox()
        cbbulan = New ComboBox()
        cbtanggal = New ComboBox()
        txtjumlah = New TextBox()
        txttelpon = New TextBox()
        txtnama = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        lblbayar = New Label()
        Label19 = New Label()
        lbljumlah = New Label()
        Label17 = New Label()
        Label16 = New Label()
        lbldiskon = New Label()
        lblharga = New Label()
        Label15 = New Label()
        Label14 = New Label()
        lbltahun = New Label()
        lbltanggal = New Label()
        lblbulan = New Label()
        lbljam = New Label()
        lblkelas = New Label()
        lbltujuan = New Label()
        l = New Label()
        lbltelpon = New Label()
        lblnama = New Label()
        GroupBox3 = New GroupBox()
        Label9 = New Label()
        Label1 = New Label()
        btnpesan = New Button()
        btnreset = New Button()
        btnclose = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbkelas)
        GroupBox1.Controls.Add(cbtujuan)
        GroupBox1.Controls.Add(cbjam)
        GroupBox1.Controls.Add(cbtahun)
        GroupBox1.Controls.Add(cbbulan)
        GroupBox1.Controls.Add(cbtanggal)
        GroupBox1.Controls.Add(txtjumlah)
        GroupBox1.Controls.Add(txttelpon)
        GroupBox1.Controls.Add(txtnama)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(45, 66)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(674, 225)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "[Pemesanan Tiket]"
        ' 
        ' cbkelas
        ' 
        cbkelas.FormattingEnabled = True
        cbkelas.Items.AddRange(New Object() {"Patas", "Ekonomi", "Bisnis", "Executif"})
        cbkelas.Location = New Point(475, 82)
        cbkelas.Name = "cbkelas"
        cbkelas.Size = New Size(151, 28)
        cbkelas.TabIndex = 15
        ' 
        ' cbtujuan
        ' 
        cbtujuan.FormattingEnabled = True
        cbtujuan.Items.AddRange(New Object() {"BALI", "BANDUNG", "WONOSOBO", "KUNINGAN", "JAKARTA"})
        cbtujuan.Location = New Point(475, 33)
        cbtujuan.Name = "cbtujuan"
        cbtujuan.Size = New Size(151, 28)
        cbtujuan.TabIndex = 14
        ' 
        ' cbjam
        ' 
        cbjam.FormattingEnabled = True
        cbjam.Items.AddRange(New Object() {"06.00", "08.00", "10.00", "12.00"})
        cbjam.Location = New Point(175, 171)
        cbjam.Name = "cbjam"
        cbjam.Size = New Size(178, 28)
        cbjam.TabIndex = 13
        ' 
        ' cbtahun
        ' 
        cbtahun.FormattingEnabled = True
        cbtahun.Items.AddRange(New Object() {"2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        cbtahun.Location = New Point(306, 120)
        cbtahun.Name = "cbtahun"
        cbtahun.Size = New Size(47, 28)
        cbtahun.TabIndex = 12
        ' 
        ' cbbulan
        ' 
        cbbulan.FormattingEnabled = True
        cbbulan.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER ", "DESEMBER"})
        cbbulan.Location = New Point(216, 121)
        cbbulan.Name = "cbbulan"
        cbbulan.Size = New Size(84, 28)
        cbbulan.TabIndex = 11
        ' 
        ' cbtanggal
        ' 
        cbtanggal.FormattingEnabled = True
        cbtanggal.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cbtanggal.Location = New Point(175, 121)
        cbtanggal.Name = "cbtanggal"
        cbtanggal.Size = New Size(37, 28)
        cbtanggal.TabIndex = 10
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(501, 173)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(125, 27)
        txtjumlah.TabIndex = 9
        ' 
        ' txttelpon
        ' 
        txttelpon.Location = New Point(175, 78)
        txttelpon.Name = "txttelpon"
        txttelpon.Size = New Size(125, 27)
        txttelpon.TabIndex = 8
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(175, 41)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(125, 27)
        txtnama.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(396, 176)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 20)
        Label8.TabIndex = 6
        Label8.Text = "Jumlah Tiket:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(396, 82)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 20)
        Label7.TabIndex = 5
        Label7.Text = "Kelas:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(396, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 4
        Label6.Text = "Tujuan:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 20)
        Label5.TabIndex = 3
        Label5.Text = "Jam Pemberangkatan:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 2
        Label4.Text = "Tgl Pemesanan:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 1
        Label3.Text = "No Telpon:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama Pemesan:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblbayar)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(lbljumlah)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(lbldiskon)
        GroupBox2.Controls.Add(lblharga)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(lbltahun)
        GroupBox2.Controls.Add(lbltanggal)
        GroupBox2.Controls.Add(lblbulan)
        GroupBox2.Controls.Add(lbljam)
        GroupBox2.Controls.Add(lblkelas)
        GroupBox2.Controls.Add(lbltujuan)
        GroupBox2.Controls.Add(l)
        GroupBox2.Controls.Add(lbltelpon)
        GroupBox2.Controls.Add(lblnama)
        GroupBox2.Location = New Point(45, 297)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(530, 264)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "[Detail Pesanan]"
        ' 
        ' lblbayar
        ' 
        lblbayar.AutoSize = True
        lblbayar.Location = New Point(391, 90)
        lblbayar.Name = "lblbayar"
        lblbayar.Size = New Size(15, 20)
        lblbayar.TabIndex = 18
        lblbayar.Text = "-"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(283, 90)
        Label19.Name = "Label19"
        Label19.Size = New Size(86, 20)
        Label19.TabIndex = 17
        Label19.Text = "Total Bayar:"
        ' 
        ' lbljumlah
        ' 
        lbljumlah.AutoSize = True
        lbljumlah.Location = New Point(391, 43)
        lbljumlah.Name = "lbljumlah"
        lbljumlah.Size = New Size(15, 20)
        lbljumlah.TabIndex = 16
        lbljumlah.Text = "-"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(283, 43)
        Label17.Name = "Label17"
        Label17.Size = New Size(94, 20)
        Label17.TabIndex = 15
        Label17.Text = "Jumlah Tiket:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(21, 212)
        Label16.Name = "Label16"
        Label16.Size = New Size(57, 20)
        Label16.TabIndex = 14
        Label16.Text = "Diskon:"
        ' 
        ' lbldiskon
        ' 
        lbldiskon.AutoSize = True
        lbldiskon.Location = New Point(86, 212)
        lbldiskon.Name = "lbldiskon"
        lbldiskon.Size = New Size(15, 20)
        lbldiskon.TabIndex = 13
        lbldiskon.Text = "-"
        ' 
        ' lblharga
        ' 
        lblharga.AutoSize = True
        lblharga.Location = New Point(130, 170)
        lblharga.Name = "lblharga"
        lblharga.Size = New Size(15, 20)
        lblharga.TabIndex = 11
        lblharga.Text = "-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(20, 170)
        Label15.Name = "Label15"
        Label15.Size = New Size(89, 20)
        Label15.TabIndex = 10
        Label15.Text = "Harga Tiket:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(21, 133)
        Label14.Name = "Label14"
        Label14.Size = New Size(38, 20)
        Label14.TabIndex = 9
        Label14.Text = "Jam:"
        ' 
        ' lbltahun
        ' 
        lbltahun.AutoSize = True
        lbltahun.Location = New Point(158, 94)
        lbltahun.Name = "lbltahun"
        lbltahun.Size = New Size(15, 20)
        lbltahun.TabIndex = 8
        lbltahun.Text = "-"
        ' 
        ' lbltanggal
        ' 
        lbltanggal.AutoSize = True
        lbltanggal.Location = New Point(84, 94)
        lbltanggal.Name = "lbltanggal"
        lbltanggal.Size = New Size(15, 20)
        lbltanggal.TabIndex = 7
        lbltanggal.Text = "-"
        ' 
        ' lblbulan
        ' 
        lblbulan.AutoSize = True
        lblbulan.Location = New Point(115, 94)
        lblbulan.Name = "lblbulan"
        lblbulan.Size = New Size(15, 20)
        lblbulan.TabIndex = 6
        lblbulan.Text = "-"
        ' 
        ' lbljam
        ' 
        lbljam.AutoSize = True
        lbljam.Location = New Point(73, 133)
        lbljam.Name = "lbljam"
        lbljam.Size = New Size(15, 20)
        lbljam.TabIndex = 5
        lbljam.Text = "-"
        ' 
        ' lblkelas
        ' 
        lblkelas.AutoSize = True
        lblkelas.Location = New Point(86, 56)
        lblkelas.Name = "lblkelas"
        lblkelas.Size = New Size(15, 20)
        lblkelas.TabIndex = 4
        lblkelas.Text = "-"
        ' 
        ' lbltujuan
        ' 
        lbltujuan.AutoSize = True
        lbltujuan.Location = New Point(21, 56)
        lbltujuan.Name = "lbltujuan"
        lbltujuan.Size = New Size(15, 20)
        lbltujuan.TabIndex = 3
        lbltujuan.Text = "-"
        ' 
        ' l
        ' 
        l.AutoSize = True
        l.Location = New Point(21, 94)
        l.Name = "l"
        l.Size = New Size(64, 20)
        l.TabIndex = 2
        l.Text = "Tanggal:"
        ' 
        ' lbltelpon
        ' 
        lbltelpon.AutoSize = True
        lbltelpon.Location = New Point(84, 23)
        lbltelpon.Name = "lbltelpon"
        lbltelpon.Size = New Size(15, 20)
        lbltelpon.TabIndex = 1
        lbltelpon.Text = "-"
        ' 
        ' lblnama
        ' 
        lblnama.AutoSize = True
        lblnama.Location = New Point(21, 23)
        lblnama.Name = "lblnama"
        lblnama.Size = New Size(15, 20)
        lblnama.TabIndex = 0
        lblnama.Text = "-"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Location = New Point(45, 567)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(452, 68)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "[Informasi]"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(371, 20)
        Label9.TabIndex = 0
        Label9.Text = "Jika pembelian tiket diatas 3 mendapatkan diskon 10%"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(103, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 41)
        Label1.TabIndex = 2
        Label1.Text = "PO MAJU KENA MUNDUR KENA"
        ' 
        ' btnpesan
        ' 
        btnpesan.Location = New Point(45, 669)
        btnpesan.Name = "btnpesan"
        btnpesan.Size = New Size(94, 29)
        btnpesan.TabIndex = 1
        btnpesan.Text = "PESAN"
        btnpesan.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(295, 669)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(94, 29)
        btnreset.TabIndex = 3
        btnreset.Text = "RESET"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btnclose
        ' 
        btnclose.Location = New Point(577, 669)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(94, 29)
        btnclose.TabIndex = 4
        btnclose.Text = "CLOSE"
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 762)
        Controls.Add(btnclose)
        Controls.Add(btnreset)
        Controls.Add(btnpesan)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Pemesanan Tiket"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbkelas As ComboBox
    Friend WithEvents cbtujuan As ComboBox
    Friend WithEvents cbjam As ComboBox
    Friend WithEvents cbtahun As ComboBox
    Friend WithEvents cbbulan As ComboBox
    Friend WithEvents cbtanggal As ComboBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txttelpon As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lbltahun As Label
    Friend WithEvents lbltanggal As Label
    Friend WithEvents lblbulan As Label
    Friend WithEvents lbljam As Label
    Friend WithEvents lblkelas As Label
    Friend WithEvents lbltujuan As Label
    Friend WithEvents l As Label
    Friend WithEvents lbltelpon As Label
    Friend WithEvents lblnama As Label
    Friend WithEvents lblbayar As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbljumlah As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbldiskon As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnpesan As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btnclose As Button
End Class
