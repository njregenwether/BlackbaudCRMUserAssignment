Public Class MultiUserSecurityAssignmentEditDataFormUIModel

    Private Sub MultiUserSecurityAssignmentEditDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Me._sitelist.AllowAdd = False
        Me._rolelist.AllowAdd = False
        Me._userlist.AllowAdd = False


        Me.OPERATION.Required = True
        Me.SITEFILTERMODE.Required = True
        Me._operation.Value = OPERATIONS.Add
        Me._sitefiltermode.Value = SITEFILTERMODES.AppUserSSite
        Me._sitelist.Visible = False
        Me.SaveButtonCaption = "Assign Roles"




    End Sub

    Private Sub SiteFilterMode_Changed(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.UIPropertyChangedEventArgs) Handles _sitefiltermode.PropertyChanged
        Me._sitelist.ClearSelectedItems()
        HandleSystemRoles()
    End Sub

    Private Sub HandleSystemRoles()
        If Me._sitefiltermode.Value = SITEFILTERMODES.AppUserSSite Then
            Me._sitelist.Visible = False
            Me._sitelist.Enabled = False
            ClearSiteSelections()
        ElseIf Me._sitefiltermode.Value = SITEFILTERMODES.SelectedSites Then
            Me._sitelist.Visible = True
            Me._sitelist.Enabled = True
            ClearSiteSelections()
        End If
    End Sub


    Private Sub SelectAllSites_Invoked(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _selectallsites.InvokeAction
        IttrSelectAllSites()
    End Sub

    Private Sub DeselectAllSites_Invoked(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _deselectallsites.InvokeAction
        IttrDeselectAllSites()
    End Sub

    Private Sub SelectAllRoles_Invoked(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _selectallroles.InvokeAction
        IttrSelectAllRoles()
    End Sub

    Private Sub DeselectAllRoles_Invoked(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _deselectallroles.InvokeAction
        IttrDeselectAllRoles()
    End Sub

    Private Sub SelectAllUsers_Invoked(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _selectallusers.InvokeAction
        IttrSelectAllUsers()
    End Sub

    Private Sub DeselectAllUsers_Invoked(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.InvokeActionEventArgs) Handles _deselectallusers.InvokeAction
        IttrDeselectAllUsers()
    End Sub

    Private Sub ClearSiteSelections()
        For Each item In _sitelist.Value
            item.SELECTED.Value = False
        Next
    End Sub

    Private Sub IttrSelectAllSites()
        For Each item In _sitelist.Value
            item.SELECTED.Value = True
        Next
    End Sub

    Private Sub IttrDeselectAllSites()
        For Each item In _sitelist.Value
            item.SELECTED.Value = False
        Next
    End Sub

    Private Sub IttrSelectAllRoles()
        For Each item In _rolelist.Value
            item.SELECTED.Value = True
        Next
    End Sub

    Private Sub IttrDeselectAllRoles()
        For Each item In _rolelist.Value
            item.SELECTED.Value = False
        Next
    End Sub

    Private Sub IttrSelectAllUsers()
        For Each item In _userlist.Value
            item.SELECTED.Value = True
        Next
    End Sub

    Private Sub IttrDeselectAllUsers()
        For Each item In _userlist.Value
            item.SELECTED.Value = False
        Next
    End Sub

End Class