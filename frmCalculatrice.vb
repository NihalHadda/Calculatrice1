Public Class frmCalculatrice
    Dim op As Char
    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub btn_moins_Click(sender As Object, e As EventArgs) Handles btn_moins.Click
        op = "-"
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Dim A = Integer.Parse(Txt_A.Text)
        Dim B = Integer.Parse(Txt_B.Text)
        Dim res = 0
        Dim test = True
        If op = "+" Then
            res = A + B
        ElseIf op = "-" Then
            res = A - B
        ElseIf op = "*" Then
            res = A * B
        ElseIf op = "/" And Not B = 0 Then
            res = A / B
        Else
            MessageBox.Show("Veuillez choisir un opérateur")
            test = False
        End If
        If test Then
            label_Res.Text = A.ToString + " " + op + " " + B.ToString + " = " + res.ToString

        End If
    End Sub
End Class
