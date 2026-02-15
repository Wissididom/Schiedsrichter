Imports System.Windows.Forms.Screen
Public Class Form1
    Private screens As New List(Of Rectangle)
    Private bildschirme() As Screen = Screen.AllScreens
    Public WithEvents f As New Form

    Private Sub PictureBox_red_Click(sender As Object, e As EventArgs) Handles PictureBox_red.Click
        Showf(Color.Red)
    End Sub

    Private Sub PictureBox_yellow_Click(sender As Object, e As EventArgs) Handles PictureBox_yellow.Click
        Showf(Color.Yellow)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If MsgBox("Wirklich beenden?", MsgBoxStyle.YesNo, "Sicherheitsabfrage") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempi As Integer = bildschirme.Length
        'MsgBox(tempi)
        If tempi = 2 Then
            f.BackColor = Color.Black
            f.Size = New Size(100, 100)
            f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'f.WindowState = FormWindowState.Maximized
            f.Text = ""
            f.Location = New Point(bildschirme(1).WorkingArea.Location.X, bildschirme(1).WorkingArea.Location.Y)
            f.Show()
        Else
            MsgBox("Sie haben nur einen Bildschirm angeschlossen", MsgBoxStyle.Information, "Fehler")
        End If
    End Sub

    Private Sub Button_save_red_Click(sender As Object, e As EventArgs) Handles Button_save_red.Click
        SavePictureBoxes(PictureBox_red)
    End Sub

    Private Sub Button_save_yellow_Click(sender As Object, e As EventArgs) Handles Button_save_yellow.Click
        SavePictureBoxes(PictureBox_yellow)
    End Sub

    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click
        f.Close()
    End Sub

    Private Sub f_Click(sender As Object, e As EventArgs) Handles f.Click
        f.Close()
    End Sub

    Private Sub f_Load(sender As Object, e As EventArgs) Handles f.Load
        f.ShowIcon = False
        f.StartPosition = FormStartPosition.CenterScreen
        'f.Location = New Point(f.Location.X + 10, f.Location.Y)
        f.WindowState = FormWindowState.Normal
    End Sub

    Private Sub f_Shown(sender As Object, e As EventArgs) Handles f.Shown
        f.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Showf(Farbe As System.Drawing.Color)
        Dim tempi As Integer = bildschirme.Length
        f = New System.Windows.Forms.Form
        'MsgBox(tempi)
        If tempi = 1 Then
            f.Show()
            f.BackColor = Farbe
            f.Size = New Size(100, 100)
            f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'f.WindowState = FormWindowState.Maximized
            f.Text = ""
            f.Location = bildschirme(0).WorkingArea.Location
        ElseIf tempi = 2 Then
            f.Show()
            f.BackColor = Farbe
            f.Size = New Size(100, 100)
            f.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'f.WindowState = FormWindowState.Maximized
            f.Text = ""
            f.Location = bildschirme(1).WorkingArea.Location
        Else
            MsgBox("Bei der Bildschirmerkennung ist ein Fehler aufgetreten", MsgBoxStyle.Critical, "Fehler")
        End If
    End Sub

    Private Sub SavePictureBoxes(Element As PictureBox)
        If SFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If SFD.FilterIndex = 0 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf SFD.FilterIndex = 1 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf SFD.FilterIndex = 2 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Exif)
            ElseIf SFD.FilterIndex = 3 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf SFD.FilterIndex = 4 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Emf)
            ElseIf SFD.FilterIndex = 5 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Gif)
            ElseIf SFD.FilterIndex = 6 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Icon)
            ElseIf SFD.FilterIndex = 7 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
            ElseIf SFD.FilterIndex = 8 Then
                Element.Image.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Wmf)
            Else
                Element.Image.Save(SFD.FileName)
            End If
        End If
    End Sub
End Class