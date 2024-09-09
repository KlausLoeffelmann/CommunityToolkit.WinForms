Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private _modernApp As Boolean = True

        Private Sub MyApplication_ApplyApplicationDefaults(
            sender As Object,
            e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults

            ' Switch to dark mode.
            e.ColorMode = If(_modernApp, SystemColorMode.Dark, SystemColorMode.Classic)

            ' Enable latest A11Y conform visual styles.
            e.VisualStylesMode = If(_modernApp, VisualStylesMode.Latest, VisualStylesMode.Classic)

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Debug.Print($"Unhandled Exception in Application:{e.Exception}")
            ' We try to continue the app.
            e.ExitApplication = False
        End Sub
    End Class
End Namespace
