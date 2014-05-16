Public Class Form1

    Public newFPS As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Convert.ToInt32(Keys.Up)) Then
            Player.Top = Player.Top - 5
            newFPS = newFPS + 1
        End If
        If GetAsyncKeyState(Convert.ToInt32(Keys.Down)) Then
            Player.Top = Player.Top + 5
            newFPS = newFPS + 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = "FPS: " & newFPS
        newFPS = 0
    End Sub
End Class
