Public Class MakeUserLikeEditDataFormUIModel

    Private Sub MakeUserLikeEditDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Me.SaveButtonCaption = "Apply Security Changes"

        Me.SaveButtonEnabled = False
    End Sub

    Private Sub SourceUserField_Changed(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.ValueChangedEventArgs) Handles _sourceuser.ValueChanged
        CheckSelections()
    End Sub


    Private Sub UserListSelection_Changed(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.SelectionChangedEventArgs) Handles _userlist.SelectionChanged
        CheckSelections()
    End Sub

    Private Sub CheckSelections()
        If Me._sourceuser.Value <> Guid.Empty And _userlist.SelectedItems.Count > 0 Then
            Me.SaveButtonEnabled = True
        End If
    End Sub

End Class