Public Class Form3
    Dim verif As Boolean
    Dim plus As Integer

    Private Sub Enable_False()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private Sub scor()
        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Then
            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If
        If (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            Button1.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            Button1.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button9.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            Button4.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Then
            Button7.BackColor = Color.HotPink
            Button8.BackColor = Color.HotPink
            Button9.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            Button2.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button8.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            Button3.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button9.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            Button3.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label3.Text)
            Label3.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        '---------------------------------------------------------------------------------------------------------------------

        If (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            Button1.BackColor = Color.HotPink
            Button2.BackColor = Color.HotPink
            Button3.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If
        If (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            Button1.BackColor = Color.HotPink
            Button4.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            Button1.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button9.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            Button4.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            Button7.BackColor = Color.HotPink
            Button8.BackColor = Color.HotPink
            Button9.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul X", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            Button2.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button8.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            Button3.BackColor = Color.HotPink
            Button6.BackColor = Color.HotPink
            Button9.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If

        If (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            Button3.BackColor = Color.HotPink
            Button5.BackColor = Color.HotPink
            Button7.BackColor = Color.HotPink
            MessageBox.Show("Castigator este jucatorul O", "X si O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plus = Convert.ToInt64(Label4.Text)
            Label4.Text = Convert.ToString(plus + 1)
            Enable_False()
        End If


    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (verif = False) Then
            Button1.Text = "X"
            verif = True
        Else
            Button1.Text = "O"
            verif = False
        End If
        scor()
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (verif = False) Then
            Button2.Text = "X"
            verif = True
        Else
            Button2.Text = "O"
            verif = False
        End If
        scor()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (verif = False) Then
            Button3.Text = "X"
            verif = True
        Else
            Button3.Text = "O"
            verif = False
        End If
        scor()
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (verif = False) Then
            Button4.Text = "X"
            verif = True
        Else
            Button4.Text = "O"
            verif = False
        End If
        scor()
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (verif = False) Then
            Button5.Text = "X"
            verif = True
        Else
            Button5.Text = "O"
            verif = False
        End If
        scor()
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (verif = False) Then
            Button6.Text = "X"
            verif = True
        Else
            Button6.Text = "O"
            verif = False
        End If
        scor()
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (verif = False) Then
            Button7.Text = "X"
            verif = True
        Else
            Button7.Text = "O"
            verif = False
        End If
        scor()
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (verif = False) Then
            Button8.Text = "X"
            verif = True
        Else
            Button8.Text = "O"
            verif = False
        End If
        scor()
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (verif = False) Then
            Button9.Text = "X"
            verif = True
        Else
            Button9.Text = "O"
            verif = False
        End If
        scor()
        Button9.Enabled = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Label3.Text = "0"
        Label4.Text = "0"

        verif = False

        Button1.BackColor = Color.GhostWhite
        Button2.BackColor = Color.GhostWhite
        Button3.BackColor = Color.GhostWhite
        Button4.BackColor = Color.GhostWhite
        Button5.BackColor = Color.GhostWhite
        Button6.BackColor = Color.GhostWhite
        Button7.BackColor = Color.GhostWhite
        Button8.BackColor = Color.GhostWhite
        Button9.BackColor = Color.GhostWhite
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button12.Enabled = True
        verif = False

        Button1.BackColor = Color.GhostWhite
        Button2.BackColor = Color.GhostWhite
        Button3.BackColor = Color.GhostWhite
        Button4.BackColor = Color.GhostWhite
        Button5.BackColor = Color.GhostWhite
        Button6.BackColor = Color.GhostWhite
        Button7.BackColor = Color.GhostWhite
        Button8.BackColor = Color.GhostWhite
        Button9.BackColor = Color.GhostWhite
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class