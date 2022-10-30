Imports System.Diagnostics
Imports System.Text.RegularExpressions

Public Class Form1

    Enum Operations
        Add
        Substract
        Multiply
        Divide
        None
    End Enum

    Dim iFirstNumber As String = ""
    Dim iSecondNumber As String = ""
    Dim enumCurrentOperation As Operations

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "0"
            End If
            txtMain.Text += "0"
        Else
            txtMain.Text = "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "1"
            End If
            txtMain.Text += "1"
        Else
            txtMain.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "2"
            End If
            txtMain.Text += "2"
        Else
            txtMain.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "3"
            End If
            txtMain.Text += "3"
        Else
            txtMain.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "4"
            End If
            txtMain.Text += "4"
        Else
            txtMain.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "5"
            End If
            txtMain.Text += "5"
        Else
            txtMain.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "6"
            End If
            txtMain.Text += "6"
        Else
            txtMain.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "7"
            End If
            txtMain.Text += "7"
        Else
            txtMain.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "8"
            End If
            txtMain.Text += "8"
        Else
            txtMain.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtMain.Text <> "0" And txtMain.Text <> "ERROR" Then
            If iFirstNumber <> "" Then
                iSecondNumber += "9"
            End If
            txtMain.Text += "9"
        Else
            txtMain.Text = "9"
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        Dim iDots As Integer = 0

        If iFirstNumber = "" Then
            For Each c As Char In txtMain.Text
                If c = "." Then
                    iDots += 1
                End If
            Next
        Else
            For Each c As Char In iSecondNumber
                If c = "." Then
                    iDots += 1
                End If
            Next
        End If



        If iDots > 0 Or txtMain.Text.EndsWith(".") Or txtMain.Text.EndsWith("+") Or txtMain.Text.EndsWith("-") Or txtMain.Text.EndsWith("/") Or txtMain.Text.EndsWith("*") Then

        Else
            If iFirstNumber <> "" Then
                iSecondNumber += "."
            End If
            txtMain.Text += "."
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If txtMain.Text.EndsWith(".") Or txtMain.Text.EndsWith("+") Or txtMain.Text.EndsWith("-") Or txtMain.Text.EndsWith("/") Or txtMain.Text.EndsWith("*") Then

        ElseIf iFirstNumber = "" Then
            iFirstNumber = txtMain.Text
            enumCurrentOperation = Operations.Multiply
            txtMain.Text += "*"
        Else
            result()
            If txtMain.Text <> "ERROR" Then
                enumCurrentOperation = Operations.Multiply
                iFirstNumber = txtMain.Text
                iSecondNumber = ""
                txtMain.Text += "*"
            Else
                clean()
            End If
        End If
    End Sub

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        If txtMain.Text.EndsWith(".") Or txtMain.Text.EndsWith("+") Or txtMain.Text.EndsWith("-") Or txtMain.Text.EndsWith("/") Or txtMain.Text.EndsWith("*") Then

        ElseIf iFirstNumber = "" Then
            iFirstNumber = txtMain.Text
            enumCurrentOperation = Operations.Substract
            txtMain.Text += "-"
        Else
            result()
            If txtMain.Text <> "ERROR" Then
                enumCurrentOperation = Operations.Substract
                iFirstNumber = txtMain.Text
                iSecondNumber = ""
                txtMain.Text += "-"
            Else
                clean()
            End If
        End If
    End Sub

    Private Sub btnAdition_Click(sender As Object, e As EventArgs) Handles btnAdition.Click
        If txtMain.Text.EndsWith(".") Or txtMain.Text.EndsWith("+") Or txtMain.Text.EndsWith("-") Or txtMain.Text.EndsWith("/") Or txtMain.Text.EndsWith("*") Then

        ElseIf iFirstNumber = "" Then
            iFirstNumber = txtMain.Text
            enumCurrentOperation = Operations.Add
            txtMain.Text += "+"
        Else
            result()
            If txtMain.Text <> "ERROR" Then
                enumCurrentOperation = Operations.Add
                iFirstNumber = txtMain.Text
                iSecondNumber = ""
                txtMain.Text += "+"
            Else
                clean()
            End If
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If txtMain.Text.EndsWith(".") Or txtMain.Text.EndsWith("+") Or txtMain.Text.EndsWith("-") Or txtMain.Text.EndsWith("/") Or txtMain.Text.EndsWith("*") Then

        ElseIf iFirstNumber = "" Then
            iFirstNumber = txtMain.Text
            enumCurrentOperation = Operations.Divide
            txtMain.Text += "/"
        Else
            result()
            If txtMain.Text <> "ERROR" Then
                enumCurrentOperation = Operations.Divide
                iFirstNumber = txtMain.Text
                iSecondNumber = ""
                txtMain.Text += "/"
            Else
                clean()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMain.Text = "0"
        clean()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        result()

    End Sub
    Public Function result()
        Dim stResult As String
        If iFirstNumber = "" Or iSecondNumber = "" Or enumCurrentOperation = Operations.None Then
            stResult = "ERROR"
        Else
            Select Case enumCurrentOperation
                Case Operations.Add
                    stResult = CDec(iFirstNumber) + CDec(iSecondNumber)
                Case Operations.Substract
                    stResult = CDec(iFirstNumber) - CDec(iSecondNumber)
                Case Operations.Multiply
                    stResult = CDec(iFirstNumber) * CDec(iSecondNumber)
                Case Operations.Divide
                    If iSecondNumber <> "0" Then
                        stResult = CDec(iFirstNumber) / CDec(iSecondNumber)
                    Else
                        stResult = "ERROR"
                    End If
                Case Else
                    stResult = "ERROR"
            End Select
        End If
        txtMain.Text = stResult
        clean()
    End Function

    Public Function clean()
        enumCurrentOperation = Operations.None
        iFirstNumber = ""
        iSecondNumber = ""
    End Function

End Class


