Public Class Form1
    Private Sub lblnama_Click(sender As Object, e As EventArgs) Handles lblnama.Click

    End Sub

    Private Sub btnpesan_Click(sender As Object, e As EventArgs) Handles btnpesan.Click
        If cbtujuan.Text = "BALI" And cbkelas.Text = "Ekonomi" Then
            lblharga.Text = "100000"
        ElseIf cbtujuan.Text = "BALI" And cbkelas.Text = "Patas" Then
            lblharga.Text = "110000"
        ElseIf cbtujuan.Text = "BALI" And cbkelas.Text = "Bisnis" Then
            lblharga.Text = "120000"
        ElseIf cbtujuan.Text = "BALI" And cbkelas.Text = "Executif" Then
            lblharga.Text = "130000"
        ElseIf cbtujuan.Text = "BANDUNG" And cbkelas.Text = "Ekonomi" Then
            lblharga.Text = "80000"
        ElseIf cbtujuan.Text = "BANDUNG" And cbkelas.Text = "Patas" Then
            lblharga.Text = "90000"
        ElseIf cbtujuan.Text = "BANDUNG" And cbkelas.Text = "Bisnis" Then
            lblharga.Text = "100000"
        ElseIf cbtujuan.Text = "BANDUNG" And cbkelas.Text = "Executif" Then
            lblharga.Text = "110000"
        ElseIf cbtujuan.Text = "WONOSOBO" And cbkelas.Text = "Ekonomi" Then
            lblharga.Text = "80000"
        ElseIf cbtujuan.Text = "WONOSOBO" And cbkelas.Text = "Patas" Then
            lblharga.Text = "90000"
        ElseIf cbtujuan.Text = "WONOSOBO" And cbkelas.Text = "Bisnis" Then
            lblharga.Text = "100000"
        ElseIf cbtujuan.Text = "WONOSOBO" And cbkelas.Text = "Executif" Then
            lblharga.Text = "110000"
        ElseIf cbtujuan.Text = "KUNINGAN" And cbkelas.Text = "Ekonomi" Then
            lblharga.Text = "40000"
        ElseIf cbtujuan.Text = "KUNINGAN" And cbkelas.Text = "Patas" Then
            lblharga.Text = "50000"
        ElseIf cbtujuan.Text = "KUNINGAN" And cbkelas.Text = "Bisnis" Then
            lblharga.Text = "80000"
        ElseIf cbtujuan.Text = "KUNINGAN" And cbkelas.Text = "Executif" Then
            lblharga.Text = "110000"
        ElseIf cbtujuan.Text = "JAKARTA" And cbkelas.Text = "Ekonomi" Then
            lblharga.Text = "30000"
        ElseIf cbtujuan.Text = "JAKARTA" And cbkelas.Text = "Patas" Then
            lblharga.Text = "50000"
        ElseIf cbtujuan.Text = "JAKARTA" And cbkelas.Text = "Bisnis" Then
            lblharga.Text = "70000"
        ElseIf cbtujuan.Text = "JAKARTA" And cbkelas.Text = "Executif" Then
            lblharga.Text = "90000"
        End If

        Dim jumlah, harga, total, diskon As Double
        jumlah = Val(txtjumlah.Text)
        harga = Val(lblharga.Text)
        total = jumlah * harga

        If jumlah >= 3 Then
            diskon = total * 0.1
            total = total - diskon
        End If

        lblbayar.Text = jumlah
        lbldiskon.Text = diskon
        lbljumlah.Text = txtjumlah.Text
        lblnama.Text = txtnama.Text
        lbltelpon.Text = txttelpon.Text
        l.Text = cbtanggal.Text
        lblbulan.Text = cbbulan.Text
        lbltahun.Text = cbtahun.Text
        lbltujuan.Text = cbtujuan.Text
        lblkelas.Text = cbkelas.Text
        lbljam.Text = cbjam.Text

        lblharga.Text = Format(harga, "###,###")
        lbldiskon.Text = Format(harga, "###,###")
        lblbayar.Text = Format(harga, "###,###")

    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtnama.Text = ""
        txttelpon.Text = ""
        cbtanggal.Text = ""
        cbbulan.Text = ""
        cbtahun.Text = ""
        cbjam.Text = ""
        cbtujuan.Text = ""
        cbkelas.Text = ""
        txtjumlah.Text = ""
        lblnama.Text = ""
        lbltelpon.Text = ""
        lbltujuan.Text = ""
        lblkelas.Text = ""
        lbltanggal.Text = ""
        lblharga.Text = ""
        lbldiskon.Text = ""
        lblbayar.Text = ""
        lbljumlah.Text = ""
        lblbulan.Text = ""
        lbltahun.Text = ""
        lbltanggal.Text = ""
        lbljam.Text = ""




    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class
