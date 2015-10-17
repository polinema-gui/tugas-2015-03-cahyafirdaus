
Public Class Bintang
    Dim hasil As String = ""

    Private Sub BUTTON_PROSES_Click(sender As Object, e As EventArgs) Handles BUTTON_PROSES.Click
        Try
            Select Case COMBO_POLA.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(TEKSBOX_BARIS.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(TEKSBOX_BARIS.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(TEKSBOX_BARIS.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(TEKSBOX_BARIS.Text))
                Case Else
                    TEKSBOX_HASIL.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            TEKSBOX_HASIL.Text = "Masukan Bukan Angka"
        End Try
    End Sub

    Private Sub pyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TEKSBOX_HASIL.Text = hasil
        hasil = ""
    End Sub

    Private Sub hollowPyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TEKSBOX_HASIL.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            batasKolom1 += 1
            batasKolom2 -= 1
        Next
        TEKSBOX_HASIL.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub hollowInvertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batasKolom1 += 1
            batasKolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        TEKSBOX_HASIL.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub TEKSBOX_HASIL_TextChanged(sender As Object, e As EventArgs) Handles TEKSBOX_HASIL.TextChanged

    End Sub
    Private Sub LABEL_POLA_Click(sender As Object, e As EventArgs) Handles LABEL_POLA.Click

    End Sub
    Private Sub LABEL_BARIS_Click(sender As Object, e As EventArgs) Handles LABEL_BARIS.Click

    End Sub
    Private Sub TEKSBOX_BARIS_TextChanged(sender As Object, e As EventArgs) Handles TEKSBOX_BARIS.TextChanged

    End Sub
    Private Sub COMBO_POLA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBO_POLA.SelectedIndexChanged

    End Sub
End Class


