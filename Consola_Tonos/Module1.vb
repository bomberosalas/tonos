Module Module1

    Sub ColorE(ByVal etiqueta As Label)
        If etiqueta.ForeColor = Color.MidnightBlue Then
            etiqueta.ForeColor = Color.Gainsboro
        Else
            etiqueta.ForeColor = Color.MidnightBlue
        End If
    End Sub

End Module
