' Updated by XamlIntelliSenseFileGenerator 17.06.2020 3:48:46
#ExternalChecksum ("..\..\Project_main.xaml", "{8829d00f-11b8-4213-878b-770e8597ac16}", "89DFF1DF29E39801A8B9D2253771AD669C1261D7A6DAD463BCEEAA715097BCBC")
'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports ESModCreator__Remastered
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Project_main
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Project_main
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector

#End ExternalSource


#ExternalSource ("..\..\Project_main.xaml", 10)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")> _
    Friend WithEvents Code As System.Windows.Controls.TextBox

#End ExternalSource

    Private _contentLoaded As Boolean

    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")> _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/ESModCreator  Remastered;component/project_main.xaml", System.UriKind.Relative)

#ExternalSource ("..\..\Project_main.xaml", 1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)

#End ExternalSource
    End Sub

    <System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"), _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never), _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"), _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"), _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")> _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.Project_main_n = CType(target, Project_main)
            Return
        End If
        If (connectionId = 2) Then
            Me.Code = CType(target, System.Windows.Controls.TextBox)
            Return
        End If
        Me._contentLoaded = true
    End Sub

    Friend WithEvents Project_main_n As System.Windows.Window
End Class

