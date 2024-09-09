Public Class ContainerLayoutTests
    Inherits ContainerControl

    Sub New()
        MyBase.New

        Dim flowLayoutPanel As New FlowLayoutPanel With
        {
            .Dock = DockStyle.Fill,
            .FlowDirection = FlowDirection.LeftToRight,
            .WrapContents = True
        }

        ' Add 50 buttons to the FlowLayoutPanel

        For z = 0 To 2
            For i As Integer = 1 To 50
                Dim button As New Button With
                {
                    .Text = $"Button {i}",
                    .AutoSize = True,
                    .FlatStyle = z
                }

                flowLayoutPanel.Controls.Add(button)
            Next
        Next

        Me.Controls.Add(flowLayoutPanel)
        Me.Dock = DockStyle.Fill

    End Sub

End Class
