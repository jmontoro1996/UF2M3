Public Class calcFUNCION
    Private Function operar(ByVal op1 As Integer, ByVal op2 As Integer, ByVal operacion As Integer) As Integer

        Select Case operacion

            Case 1
                Return op1 + op2
            Case 2
                Return op1 - op1
            Case 3
                Return op1 * op2
            Case 4
                Return op1 / op2
        End Select

    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Integer
        Dim op1 As Integer = TextBox1.Text
        Dim op2 As Integer = TextBox2.Text


        res = Me.operar(op1, op2, 1)
        TextBox3.Text = res
    End Sub
End Class