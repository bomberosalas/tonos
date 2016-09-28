Public Class Interfaz
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        ColorE(sender)
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        ColorE(sender)
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        ColorE(sender)
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        ColorE(sender)
    End Sub

    Private Sub R2_Click(sender As Object, e As EventArgs) Handles R2.Click
        ColorE(sender)
    End Sub

    Private Sub RX2_Click(sender As Object, e As EventArgs) Handles RX2.Click
        ColorE(sender)
    End Sub

    Private Sub R4_Click(sender As Object, e As EventArgs) Handles R4.Click
        ColorE(sender)
    End Sub

    Private Sub Z1_Click(sender As Object, e As EventArgs) Handles Z1.Click
        ColorE(sender)
    End Sub

    Private Sub K1_Click(sender As Object, e As EventArgs) Handles K1.Click
        ColorE(sender)
    End Sub

    Private Sub Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub tono(ByVal file As String)

        Try
            PTT.Open()
            PTT.RtsEnable = True
            System.Threading.Thread.Sleep(1000)
            My.Computer.Audio.Play(file, AudioPlayMode.WaitToComplete)
            System.Threading.Thread.Sleep(1000)
            PTT.RtsEnable = False
            PTT.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Alerta124Bt_Click(sender As Object, e As EventArgs) Handles Alerta124Bt.Click
        If MsgBox("Desea Activar el despacho", MsgBoxStyle.OkCancel, "Confirmación de Despacho") = MsgBoxResult.Ok Then
            tono("c:\alerta.wav")
        End If
    End Sub


    <Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr,
              ByVal Msg As Integer, ByVal wParam As IntPtr,
              ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub btnMute_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND,
                      Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub
End Class
