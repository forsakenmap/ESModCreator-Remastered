Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO

Class MainWindow
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Loaded
        Logos.Source = BitmapToImage(My.Resources.Logo)
        Dim fontFamilies() As FontFamily
        Dim installedFontCollection As New InstalledFontCollection()
        fontFamilies = installedFontCollection.Families
        Dim count As Integer = fontFamilies.Length
        Dim j As Integer
        Dim detect As Integer = 0
        While j < count
            If fontFamilies(j).Name = "DO NOT LEAN ON DOOR" Then
                detect = 1
            End If
            j += 1
        End While
        If detect = 0 Then
            If MsgBox("Для нормального отображения всех элементов программы рекомендую установить следующий шрифт (окно установки откроется автоматически при нажатии кнопки 'OK')", MsgBoxStyle.OkCancel) = 1 Then
                Process.Start(Directory.GetCurrentDirectory + "/Font/DO_NOT_LEAN_ON_DOOR.otf")
            End If
        End If
        If Not My.Computer.FileSystem.DirectoryExists("hints/") Then
            My.Computer.FileSystem.CreateDirectory("hints/")
        End If
        If Not SearchFile("hints/ambience.txt") Then
            CreateTXT(My.Resources.ambience, "hints/ambience.txt")
        End If
        If Not SearchFile("hints/bg.txt") Then
            CreateTXT(My.Resources.bg, "hints/bg.txt")
        End If
        If Not SearchFile("hints/cg.txt") Then
            CreateTXT(My.Resources.cg, "hints/cg.txt")
        End If
        If Not SearchFile("hints/commands.txt") Then
            CreateTXT(My.Resources.commands, "hints/commands.txt")
        End If
        If Not SearchFile("hints/music.txt") Then
            CreateTXT(My.Resources.music, "hints/music.txt")
        End If
        If Not SearchFile("hints/sprites.txt") Then
            CreateTXT(My.Resources.sprites, "hints/sprites.txt")
        End If
        If Not SearchFile("hints/text.txt") Then
            CreateTXT(My.Resources.text, "hints/text.txt")
        End If
    End Sub
    Private Sub Project_button_Click(sender As Object, e As RoutedEventArgs) Handles Project_button.Click

    End Sub
    Private Sub Logo_Click(sender As Object, e As RoutedEventArgs) Handles Logos.MouseUp
        Process.Start("https://vk.com/esmodcreator")
    End Sub

    Private Sub RPY_Edit_button_Click(sender As Object, e As RoutedEventArgs) Handles RPY_Edit_button.Click
        Dim a As New Edit_RPY
        a.Show()
        Me.Close()
    End Sub
    Private Sub About_US_Click(sender As Object, e As RoutedEventArgs) Handles About_US.Click
        Process.Start("https://vk.com/esmodcreator")
    End Sub
    Shared Function BitmapToImage(ByVal btm As Bitmap) As BitmapImage
        Dim ms As New MemoryStream()
        CType(btm, Bitmap).Save(ms, Imaging.ImageFormat.Bmp)
        Dim image As New BitmapImage()
        image.BeginInit()
        ms.Seek(0, SeekOrigin.Begin)
        image.StreamSource = ms
        image.EndInit()
        Return image
    End Function
    Shared Function SearchFile(ByVal name As String)
        Return My.Computer.FileSystem.FileExists(name)
    End Function
    Shared Function CreateTXT(ByVal text, ByVal directory)
        Try
            My.Computer.FileSystem.WriteAllText(directory, text, False)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class

