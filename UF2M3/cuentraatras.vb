Public Class cuentraatras
    Dim c1 As Double = 10
    Dim c2 As Double = 20
    Dim c3 As Double = 30
    Dim nivel As Integer
    Dim opera As Integer
    Dim r As New Random
    Dim n1, n2 As Integer
    Dim operacion As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nivel = 1
        opera = 1
    End Sub
    Private Function suma(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 + op2
    End Function
    Private Function resta(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 - op2
    End Function
    Private Function multi(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 * op2
    End Function
    Private Function div(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 / op2
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case opera
            Case 1
                Label4.Text = operacion
                operacion = r.Next(0, 2)
                n1 = r.Next(1, 99)
                n2 = r.Next(1, 99)
                Label2.Text = n1
                Label3.Text = n2
                If operacion = 0 Then
                    Label4.Text = "+"
                    Me.suma(n1, n2)
                Else
                    Label4.Text = "-"

                    Me.resta(n1, n2)
                End If
            Case 2
                Label4.Text = operacion
                operacion = r.Next(0, 4)
                n1 = r.Next(1, 999)
                n2 = r.Next(1, 999)
                Label2.Text = n1
                Label3.Text = n2
                If operacion = 0 Then
                    Label4.Text = "+"
                    Me.suma(n1, n2)
                ElseIf operacion = 1 Then
                    Label4.Text = "-"

                    Me.resta(n1, n2)
                ElseIf operacion = 2 Then
                    Label4.Text = "*"
                    Me.multi(n1, n2)
                ElseIf operacion = 3 Then
                    Label4.Text = "/"
                    Me.div(n1, n2)
                End If
            Case 3
                Label4.Text = operacion
                operacion = r.Next(0, 4)
                n1 = r.Next(999, 99999)
                n2 = r.Next(999, 99999)
                Label2.Text = n1
                Label3.Text = n2
                If operacion = 0 Then
                    Label4.Text = "+"
                    Me.suma(n1, n2)
                ElseIf operacion = 1 Then
                    Label4.Text = "-"

                    Me.resta(n1, n2)
                ElseIf operacion = 2 Then
                    Label4.Text = "*"
                    Me.multi(n1, n2)
                ElseIf operacion = 3 Then
                    Label4.Text = "/"
                    Me.div(n1, n2)
                End If

        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nivel = 2
        opera = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nivel = 3
        opera = 3
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case nivel
            Case 1
                Timer1.Enabled = True
                c1 = c1 - 1
                Label1.Text = c1
                If c1 = 0 Then
                    Timer1.Enabled = False
                    MessageBox.Show("SE ACABO")
                End If
            Case 2
                Timer1.Enabled = True

                c2 = c2 - 1
                Label1.Text = c2
                If c2 = 0 Then
                    Timer1.Enabled = False
                    MessageBox.Show("SE ACABO")

                End If

            Case 3
                Timer1.Enabled = True

                c3 = c3 - 1
                Label1.Text = c3
                If c3 = 0 Then
                    Timer1.Enabled = False
                    MessageBox.Show("SE ACABO")
                End If
        End Select

    End Sub




End Class