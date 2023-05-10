Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

'Name: Wheel Of Fortune
'Purpose: Alt Wheel Of Fortune Game
'Programmers: Osscar Garcia & Anthony Badillo

Public Class Form1
    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Random As Integer

    Dim Open As New OpenFileDialog()
    Dim FilePath As String

    Dim ranIndex As Integer
    Dim ranWord As String
    Dim tempWord As String
    Dim outputwrd As String

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        lstTest.Items.Clear()
        Open.ShowDialog()

        Try
            FilePath = Open.FileName
            For Each line As String In File.ReadAllLines(Open.FileName)
                lstTest.Items.Add(line)
            Next

            ranIndex = CInt(lstTest.Items.Count * Rnd())
            ranWord = lstTest.Items(ranIndex).ToString.ToUpper

            For Each a As Char In ranWord
                tempWord += a + " "
                outputwrd += " -  "
            Next

            lblResult.Text = outputwrd

            'btnSpin.Enabled = True

        Catch ex As Exception

        End Try

        lblPhrase.Text = tempWord
    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        timer.Enabled = True
        Random = CInt((Rnd() * 25) + 25)

    End Sub
    Public Sub changeImage(num As Integer)

        If num = 0 Then
            PictureBox1.Image = My.Resources.start_of_spin
        ElseIf num = 1 Then
            PictureBox1.Image = My.Resources.Spin_1
        ElseIf num = 2 Then
            PictureBox1.Image = My.Resources.Spin_2
        ElseIf num = 3 Then
            PictureBox1.Image = My.Resources.Spin_3
        ElseIf num = 4 Then
            PictureBox1.Image = My.Resources.Spin_4
        ElseIf num = 5 Then
            PictureBox1.Image = My.Resources.Spin_5
        ElseIf num = 6 Then
            PictureBox1.Image = My.Resources.Spin_6
        ElseIf num = 7 Then
            PictureBox1.Image = My.Resources.Spin_7
        ElseIf num = 8 Then
            PictureBox1.Image = My.Resources.Spin_8
        ElseIf num = 9 Then
            PictureBox1.Image = My.Resources.Spin_9
        ElseIf num = 10 Then
            PictureBox1.Image = My.Resources.Spin_10
        ElseIf num = 11 Then
            PictureBox1.Image = My.Resources.Spin_11
        ElseIf num = 12 Then
            PictureBox1.Image = My.Resources.Spin_12
        ElseIf num = 13 Then
            PictureBox1.Image = My.Resources.Spin_13
        ElseIf num = 14 Then
            PictureBox1.Image = My.Resources.Spin_14
        ElseIf num = 15 Then
            PictureBox1.Image = My.Resources.Spin_15
        ElseIf num = 16 Then
            PictureBox1.Image = My.Resources.Spin_16
        ElseIf num = 17 Then
            PictureBox1.Image = My.Resources.Spin_17
        ElseIf num = 18 Then
            PictureBox1.Image = My.Resources.Spin_18
        ElseIf num = 19 Then
            PictureBox1.Image = My.Resources.Spin_19
        ElseIf num = 20 Then
            PictureBox1.Image = My.Resources.Spin_20
        ElseIf num = 21 Then
            PictureBox1.Image = My.Resources.Spin_21
        ElseIf num = 22 Then
            PictureBox1.Image = My.Resources.Spin_22
        ElseIf num = 23 Then
            PictureBox1.Image = My.Resources.Spin_23
        ElseIf num = 24 Then
            PictureBox1.Image = My.Resources.Spin_24
        ElseIf num = 25 Then
            PictureBox1.Image = My.Resources.Spin_25
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer.Tick

        Number2 += 1

        changeImage(Number2 Mod 25 + 1)

        If Number2 = Random Then
            timer.Enabled = False
            Number2 = Number2 Mod 25
        End If

    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles A.Click
        Dim strA As String
        strA = "A"
        A.Enabled = False
        If lblPhrase.Text.Contains(strA) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strA Then

                    outputwrd = outputwrd.Insert(intIndex, strA)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)
                    'outputwrd = outputwrd.Remove("-")

                    tempWord = tempWord.Insert(intIndex, strA)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Dim strB As String
        strB = "B"
        B.Enabled = False
        If lblPhrase.Text.Contains(strB) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strB Then

                    outputwrd = outputwrd.Insert(intIndex, strB)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)


                    tempWord = tempWord.Insert(intIndex, strB)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        Dim strC As String
        strC = "C"
        C.Enabled = False
        If lblPhrase.Text.Contains(strC) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strC Then

                    outputwrd = outputwrd.Insert(intIndex, strC)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strC)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub D_Click(sender As Object, e As EventArgs) Handles D.Click
        Dim strD As String
        strD = "D"
        D.Enabled = False
        If lblPhrase.Text.Contains(strD) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strD Then

                    outputwrd = outputwrd.Insert(intIndex, strD)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)


                    tempWord = tempWord.Insert(intIndex, strD)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub E_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim strE As String
        strE = "E"
        btnE.Enabled = False
        If lblPhrase.Text.Contains(strE) Then
            ' Replace the hyphen(s) in strResult.
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strE Then

                    outputwrd = outputwrd.Insert(intIndex, strE)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strE)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub F_Click(sender As Object, e As EventArgs) Handles F.Click
        Dim strF As String
        strF = "F"
        F.Enabled = False
        If lblPhrase.Text.Contains(strF) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strF Then

                    outputwrd = outputwrd.Insert(intIndex, strF)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strF)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub G_Click(sender As Object, e As EventArgs) Handles G.Click
        Dim strG As String
        strG = "G"
        G.Enabled = False
        If lblPhrase.Text.Contains(strG) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strG Then

                    outputwrd = outputwrd.Insert(intIndex, strG)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strG)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub H_Click(sender As Object, e As EventArgs) Handles H.Click
        Dim strH As String
        strH = "H"
        H.Enabled = False
        If lblPhrase.Text.Contains(strH) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strH Then

                    outputwrd = outputwrd.Insert(intIndex, strH)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strH)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub I_Click(sender As Object, e As EventArgs) Handles I.Click
        Dim strI As String
        strI = "I"
        I.Enabled = False
        If lblPhrase.Text.Contains(strI) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strI Then

                    outputwrd = outputwrd.Insert(intIndex, strI)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strI)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub J_Click(sender As Object, e As EventArgs) Handles J.Click
        Dim strJ As String
        strJ = "J"
        J.Enabled = False
        If lblPhrase.Text.Contains(strJ) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strJ Then

                    outputwrd = outputwrd.Insert(intIndex, strJ)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strJ)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub K_Click(sender As Object, e As EventArgs) Handles K.Click
        Dim strK As String
        strK = "K"
        K.Enabled = False
        If lblPhrase.Text.Contains(strK) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strK Then

                    outputwrd = outputwrd.Insert(intIndex, strK)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strK)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub L_Click(sender As Object, e As EventArgs) Handles L.Click
        Dim strL As String
        strL = "L"
        L.Enabled = False
        If lblPhrase.Text.Contains(strL) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strL Then

                    outputwrd = outputwrd.Insert(intIndex, strL)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strL)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        Dim strM As String
        strM = "M"
        M.Enabled = False
        If lblPhrase.Text.Contains(strM) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strM Then

                    outputwrd = outputwrd.Insert(intIndex, strM)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strM)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub N_Click(sender As Object, e As EventArgs) Handles N.Click
        Dim strN As String
        strN = "N"
        N.Enabled = False
        If lblPhrase.Text.Contains(strN) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strN Then

                    outputwrd = outputwrd.Insert(intIndex, strN)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strN)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub O_Click(sender As Object, e As EventArgs) Handles O.Click
        Dim strO As String
        strO = "O"
        O.Enabled = False
        If lblPhrase.Text.Contains(strO) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strO Then

                    outputwrd = outputwrd.Insert(intIndex, strO)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strO)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub P_Click(sender As Object, e As EventArgs) Handles P.Click
        Dim strP As String
        strP = "P"
        P.Enabled = False
        If lblPhrase.Text.Contains(strP) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strP Then

                    outputwrd = outputwrd.Insert(intIndex, strP)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strP)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub Q_Click(sender As Object, e As EventArgs) Handles Q.Click
        Dim strQ As String
        strQ = "Q"
        Q.Enabled = False
        If lblPhrase.Text.Contains(strQ) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strQ Then

                    outputwrd = outputwrd.Insert(intIndex, strQ)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)


                    tempWord = tempWord.Insert(intIndex, strQ)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub R_Click(sender As Object, e As EventArgs) Handles R.Click
        Dim strR As String
        strR = "R"
        R.Enabled = False
        If lblPhrase.Text.Contains(strR) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strR Then

                    outputwrd = outputwrd.Insert(intIndex, strR)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strR)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub S_Click(sender As Object, e As EventArgs) Handles S.Click
        Dim strS As String
        strS = "S"
        S.Enabled = False
        If lblPhrase.Text.Contains(strS) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strS Then

                    outputwrd = outputwrd.Insert(intIndex, strS)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strS)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub T_Click(sender As Object, e As EventArgs) Handles T.Click
        Dim strT As String
        strT = "T"
        T.Enabled = False
        If lblPhrase.Text.Contains(strT) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strT Then

                    outputwrd = outputwrd.Insert(intIndex, strT)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strT)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub U_Click(sender As Object, e As EventArgs) Handles U.Click
        Dim strU As String
        strU = "U"
        U.Enabled = False
        If lblPhrase.Text.Contains(strU) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strU Then

                    outputwrd = outputwrd.Insert(intIndex, strU)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strU)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub V_Click(sender As Object, e As EventArgs) Handles V.Click
        Dim strV As String
        strV = "V"
        V.Enabled = False
        If lblPhrase.Text.Contains(strV) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strV Then

                    outputwrd = outputwrd.Insert(intIndex, strV)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strV)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub W_Click(sender As Object, e As EventArgs) Handles W.Click
        Dim strW As String
        strW = "W"
        W.Enabled = False
        If lblPhrase.Text.Contains(strW) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strW Then

                    outputwrd = outputwrd.Insert(intIndex, strW)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strW)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Dim strX As String
        strX = "X"
        X.Enabled = False
        If lblPhrase.Text.Contains(strX) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strX Then

                    outputwrd = outputwrd.Insert(intIndex, strX)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strX)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub Y_Click(sender As Object, e As EventArgs) Handles Y.Click
        Dim strY As String
        strY = "Y"
        Y.Enabled = False
        If lblPhrase.Text.Contains(strY) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strY Then

                    outputwrd = outputwrd.Insert(intIndex, strY)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strY)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub
    Private Sub Z_Click(sender As Object, e As EventArgs) Handles Z.Click
        Dim strZ As String
        strZ = "Z"
        Z.Enabled = False
        If lblPhrase.Text.Contains(strZ) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = strZ Then

                    outputwrd = outputwrd.Insert(intIndex, strZ)
                    outputwrd = outputwrd.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, strZ)
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblResult.Text = outputwrd
    End Sub

    'This is the newest code
    'Save this please
End Class
