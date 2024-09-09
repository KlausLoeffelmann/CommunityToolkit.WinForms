Public Class DataEntry
    Private Sub OptClassic_CheckedChanged(sender As Object, e As EventArgs) Handles _optClassic.CheckedChanged
        If (_optClassic.Checked) Then
            _tlpEntryFieldContainer.VisualStylesMode = VisualStylesMode.Classic
        Else
            _tlpEntryFieldContainer.VisualStylesMode = VisualStylesMode.Latest
        End If
    End Sub
End Class
