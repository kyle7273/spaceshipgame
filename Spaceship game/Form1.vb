Public Class Form1

    Public newFPS As Integer
    Public laser1Fired As Boolean
    Public laser2Fired As Boolean
    Public laser3Fired As Boolean
    Public been2secondssincefire As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        been2secondssincefire = True
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
        If GetAsyncKeyState(Convert.ToInt32(Keys.Space)) Then
                If laser1Fired = False Then
                    laser1Fired = True
                    laser.Top = Player.Top + 25
                    laser.Left = Player.Left + 50
                    laser.Visible = True
                    newFPS = newFPS + 1
                End If
        End If
        If laser.Visible = True Then
            If laser.Left > 1300 Then
                laser.Visible = False
                laser1Fired = False
            Else
                laser.Left = laser.Left + 5
                newFPS = newFPS + 1
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = "FPS: " & newFPS
        newFPS = 0
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        been2secondssincefire = True
    End Sub
End Class
