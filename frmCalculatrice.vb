Public Class frmCalculatrice
    Dim op As Char

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles A.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmCalculatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbl_res.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then
            Dim a = Integer.Parse(txt_A.Text)
            Dim b = Integer.Parse(txt_B.Text)
            Dim res = 0
            Dim test = True
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" And Not b = 0 Then
                res = a / b


            Else
                MessageBox.Show("Veuiller choisir un autre opérateur")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + " " + op + " " + b.ToString + " = " + res.ToString
            End If
        Else
            MessageBox.Show("A et B doit etre numérique")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        op = "-"
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_Div_Click(sender As Object, e As EventArgs) Handles btn_Div.Click
        op = "/"
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_A.Text = ""
        txt_B.Text = ""
        lbl_res.Text = ""
    End Sub
End Class
