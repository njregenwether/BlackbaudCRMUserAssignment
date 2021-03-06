﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.170.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Multi User Security Assignment Edit Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit, "a3a1b793-0d45-42e2-84ce-7977f7252a04", "f08e51b2-dbdb-435f-8c4a-ed4644913aac", "")>
Partial Public Class [MultiUserSecurityAssignmentEditDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Enums"

    ''' <summary>
    ''' Enumerated values for use with the OPERATION property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public Enum OPERATIONS As Integer
        [Add] = 1
        [Remove] = 2
    End Enum

    ''' <summary>
    ''' Enumerated values for use with the SITEFILTERMODE property
    ''' </summary>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public Enum SITEFILTERMODES As Integer
        [AppUserSSite] = 1
        [SelectedSites] = 2
    End Enum

#End Region

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _operation As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of OPERATIONS))
    Private WithEvents _template As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
    Private WithEvents _userlist As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormUSERLISTUIModel)
    Private WithEvents _sitefiltermode As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of SITEFILTERMODES))
    Private WithEvents _sitelist As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormSITELISTUIModel)
    Private WithEvents _rolelist As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormROLELISTUIModel)
    Private WithEvents _selectallsites As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _deselectallsites As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _selectallroles As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _deselectallroles As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _selectallusers As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _deselectallusers As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public Sub New()
        MyBase.New()

        _operation = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of OPERATIONS))
        _template = New Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        _userlist = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormUSERLISTUIModel)
        _sitefiltermode = New Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of SITEFILTERMODES))
        _sitelist = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormSITELISTUIModel)
        _rolelist = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormROLELISTUIModel)
        _selectallsites = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _deselectallsites = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _selectallroles = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _deselectallroles = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _selectallusers = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _deselectallusers = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit
        MyBase.DataFormTemplateId = New System.Guid("a3a1b793-0d45-42e2-84ce-7977f7252a04")
        MyBase.DataFormInstanceId = New System.Guid("f08e51b2-dbdb-435f-8c4a-ed4644913aac")
        MyBase.RecordType = ""
        MyBase.FORMHEADER.Value = "Assign Roles and Sites to Users"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/blackbaud.customfx.massuserroleassignment/MultiUserSecurityAssignmentEditDataForm.html"

        '
        '_operation
        '
        _operation.Name = "OPERATION"
        _operation.Caption = "Operation"
        _operation.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of OPERATIONS)) With {.Value = OPERATIONS.[Add], .Translation = "Add"})
        _operation.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of OPERATIONS)) With {.Value = OPERATIONS.[Remove], .Translation = "Remove"})
        Me.Fields.Add(_operation)
        '
        '_template
        '
        _template.Name = "TEMPLATE"
        _template.Caption = "Permission Template"
        _template.Visible = False
        Me.Fields.Add(_template)
        '
        '_userlist
        '
        _userlist.Name = "USERLIST"
        _userlist.Caption = "Choose Users"
        Me.Fields.Add(_userlist)
        '
        '_sitefiltermode
        '
        _sitefiltermode.Name = "SITEFILTERMODE"
        _sitefiltermode.Caption = "Site Filter Mode"
        _sitefiltermode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of SITEFILTERMODES)) With {.Value = SITEFILTERMODES.[AppUserSSite], .Translation = "App User's Site"})
        _sitefiltermode.DataSource.Add(New Global.Blackbaud.AppFx.UIModeling.Core.ValueListItem(Of Nullable(Of SITEFILTERMODES)) With {.Value = SITEFILTERMODES.[SelectedSites], .Translation = "Selected Sites"})
        Me.Fields.Add(_sitefiltermode)
        '
        '_sitelist
        '
        _sitelist.Name = "SITELIST"
        _sitelist.Caption = "Choose Sites"
        Me.Fields.Add(_sitelist)
        '
        '_rolelist
        '
        _rolelist.Name = "ROLELIST"
        _rolelist.Caption = "Choose Roles"
        Me.Fields.Add(_rolelist)
        '
        '_selectallsites
        '
        _selectallsites.Name = "SELECTALLSITES"
        _selectallsites.Caption = "Select all sites"
        Me.Actions.Add(_selectallsites)
        '
        '_deselectallsites
        '
        _deselectallsites.Name = "DESELECTALLSITES"
        _deselectallsites.Caption = "Deselect all sites"
        Me.Actions.Add(_deselectallsites)
        '
        '_selectallroles
        '
        _selectallroles.Name = "SELECTALLROLES"
        _selectallroles.Caption = "Select all roles"
        Me.Actions.Add(_selectallroles)
        '
        '_deselectallroles
        '
        _deselectallroles.Name = "DESELECTALLROLES"
        _deselectallroles.Caption = "Deselect all roles"
        Me.Actions.Add(_deselectallroles)
        '
        '_selectallusers
        '
        _selectallusers.Name = "SELECTALLUSERS"
        _selectallusers.Caption = "Select all users"
        Me.Actions.Add(_selectallusers)
        '
        '_deselectallusers
        '
        _deselectallusers.Name = "DESELECTALLUSERS"
        _deselectallusers.Caption = "Deselect all users"
        Me.Actions.Add(_deselectallusers)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Operation
    ''' </summary>
    <System.ComponentModel.Description("Operation")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [OPERATION]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of OPERATIONS))
        Get
            Return _operation
        End Get
    End Property
    
    ''' <summary>
    ''' Permission Template
    ''' </summary>
    <System.ComponentModel.Description("Permission Template")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [TEMPLATE]() As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        Get
            Return _template
        End Get
    End Property
    
    ''' <summary>
    ''' Choose Users
    ''' </summary>
    <System.ComponentModel.Description("Choose Users")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [USERLIST]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormUSERLISTUIModel)
        Get
            Return _userlist
        End Get
    End Property
    
    ''' <summary>
    ''' Site Filter Mode
    ''' </summary>
    <System.ComponentModel.Description("Site Filter Mode")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [SITEFILTERMODE]() As Global.Blackbaud.AppFx.UIModeling.Core.ValueListField(Of Nullable(Of SITEFILTERMODES))
        Get
            Return _sitefiltermode
        End Get
    End Property
    
    ''' <summary>
    ''' Choose Sites
    ''' </summary>
    <System.ComponentModel.Description("Choose Sites")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [SITELIST]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormSITELISTUIModel)
        Get
            Return _sitelist
        End Get
    End Property
    
    ''' <summary>
    ''' Choose Roles
    ''' </summary>
    <System.ComponentModel.Description("Choose Roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [ROLELIST]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiUserSecurityAssignmentEditDataFormROLELISTUIModel)
        Get
            Return _rolelist
        End Get
    End Property
    
    ''' <summary>
    ''' Select all sites
    ''' </summary>
    <System.ComponentModel.Description("Select all sites")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [SELECTALLSITES]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _selectallsites
        End Get
    End Property
    
    ''' <summary>
    ''' Deselect all sites
    ''' </summary>
    <System.ComponentModel.Description("Deselect all sites")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [DESELECTALLSITES]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _deselectallsites
        End Get
    End Property
    
    ''' <summary>
    ''' Select all roles
    ''' </summary>
    <System.ComponentModel.Description("Select all roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [SELECTALLROLES]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _selectallroles
        End Get
    End Property
    
    ''' <summary>
    ''' Deselect all roles
    ''' </summary>
    <System.ComponentModel.Description("Deselect all roles")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [DESELECTALLROLES]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _deselectallroles
        End Get
    End Property
    
    ''' <summary>
    ''' Select all users
    ''' </summary>
    <System.ComponentModel.Description("Select all users")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [SELECTALLUSERS]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _selectallusers
        End Get
    End Property
    
    ''' <summary>
    ''' Deselect all users
    ''' </summary>
    <System.ComponentModel.Description("Deselect all users")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.170.0")> _
    Public ReadOnly Property [DESELECTALLUSERS]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _deselectallusers
        End Get
    End Property
    
End Class
