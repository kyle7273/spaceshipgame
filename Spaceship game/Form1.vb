Public Class Form1

    'FPS count
    Public newFPS As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fix screen tearing and other render issues
        Me.DoubleBuffered = True
    End Sub

    'Declaring function GetAsyncKeyState
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'Timer to get data

        'If key pressed is up key
        If GetAsyncKeyState(Convert.ToInt32(Keys.Up)) Then
            'Move player up 5 pixels
            Player.Top = Player.Top - 5
            'Add 1 FPS to counter
            newFPS = newFPS + 1
        End If
        'else check if key pressed is down
        If GetAsyncKeyState(Convert.ToInt32(Keys.Down)) Then
            'Move player down 5 pixels
            Player.Top = Player.Top + 5
            'Add 1 FPS to counter
            newFPS = newFPS + 1
        End If
        'If the code reached this far without triggering something, eitheir the key will not be used or a key was never pressed.
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Display FPS for last round
        Label1.Text = "FPS: " & newFPS
        'Reset FPS for this round.
        newFPS = 0
    End Sub
End Class
