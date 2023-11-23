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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtpanjang = New TextBox()
        txtlebar = New TextBox()
        txtluas = New TextBox()
        txtkonversi = New TextBox()
        cbukuran = New ComboBox()
        btnmulai = New Button()
        btnselesai = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(50, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 38)
        Label1.TabIndex = 0
        Label1.Text = "Aplikasi Konversi Luas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jenis ukuran"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 2
        Label3.Text = "Panjang "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 3
        Label4.Text = "Lebar"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 318)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 20)
        Label5.TabIndex = 4
        Label5.Text = "Luas Panjang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(355, 119)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 20)
        Label6.TabIndex = 5
        Label6.Text = "harga Kamera"
        ' 
        ' txtpanjang
        ' 
        txtpanjang.Location = New Point(129, 178)
        txtpanjang.Name = "txtpanjang"
        txtpanjang.Size = New Size(125, 27)
        txtpanjang.TabIndex = 6
        ' 
        ' txtlebar
        ' 
        txtlebar.Location = New Point(129, 253)
        txtlebar.Name = "txtlebar"
        txtlebar.Size = New Size(125, 27)
        txtlebar.TabIndex = 7
        ' 
        ' txtluas
        ' 
        txtluas.Location = New Point(129, 315)
        txtluas.Name = "txtluas"
        txtluas.Size = New Size(125, 27)
        txtluas.TabIndex = 8
        ' 
        ' txtkonversi
        ' 
        txtkonversi.Location = New Point(355, 142)
        txtkonversi.Name = "txtkonversi"
        txtkonversi.Size = New Size(125, 27)
        txtkonversi.TabIndex = 9
        ' 
        ' cbukuran
        ' 
        cbukuran.FormattingEnabled = True
        cbukuran.Items.AddRange(New Object() {"km", "m", "cm"})
        cbukuran.Location = New Point(50, 119)
        cbukuran.Name = "cbukuran"
        cbukuran.Size = New Size(151, 28)
        cbukuran.TabIndex = 10
        ' 
        ' btnmulai
        ' 
        btnmulai.Location = New Point(341, 202)
        btnmulai.Name = "btnmulai"
        btnmulai.Size = New Size(94, 29)
        btnmulai.TabIndex = 11
        btnmulai.Text = "Mulai"
        btnmulai.UseVisualStyleBackColor = True
        ' 
        ' btnselesai
        ' 
        btnselesai.Location = New Point(482, 202)
        btnselesai.Name = "btnselesai"
        btnselesai.Size = New Size(94, 29)
        btnselesai.TabIndex = 12
        btnselesai.Text = "Selesai"
        btnselesai.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnselesai)
        Controls.Add(btnmulai)
        Controls.Add(cbukuran)
        Controls.Add(txtkonversi)
        Controls.Add(txtluas)
        Controls.Add(txtlebar)
        Controls.Add(txtpanjang)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "form konversi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpanjang As TextBox
    Friend WithEvents txtlebar As TextBox
    Friend WithEvents txtluas As TextBox
    Friend WithEvents txtkonversi As TextBox
    Friend WithEvents cbukuran As ComboBox
    Friend WithEvents btnmulai As Button
    Friend WithEvents btnselesai As Button
End Class
