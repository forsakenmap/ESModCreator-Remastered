﻿Imports System.Drawing
Imports System.IO

Public Class Edit_RPY
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Loaded
        preView.Source = BitmapToImage(My.Resources.No_in_this)
    End Sub
    Private Sub code_TextChanged(sender As Object, e As TextChangedEventArgs) Handles code.TextChanged
        Try
            'Замена Tab на 4 пробела
            Dim posx As Integer = code.SelectionStart
            If InStr(code.Text, "	", CompareMethod.Text) Then
                code.Text = Replace(code.Text, "	", "    ")
                posx += 4
            End If
            code.SelectionStart = posx
            Dim currentStr As String = code.GetLineText(code.GetLineIndexFromCharacterIndex(code.SelectionStart))
            num.Items.Clear()
            For a As Integer = 1 To code.LineCount
                num.Items.Add(a)
            Next
            num.SelectedIndex = code.GetLineIndexFromCharacterIndex(code.SelectionStart)
            num.ScrollIntoView(num.SelectedItem)
            code.SelectionStart = posx
            Dim st As String
            st = Replace(currentStr, "  ", "")
            '  Dim usc As StreamReader = New StreamReader("UserCommands.txt")
            ' While usc.Peek <> -1
            'Dim an As String = usc.ReadLine
            ' If InStr(an, st, CompareMethod.Text) Then
            '      hints.Items.Add(an)
            ' End If
            ' End While
            Try
                hints.Items.Clear()
                Dim tx As StreamReader = New StreamReader("hints/text.txt")
                While tx.Peek <> -1
                    Dim an As String = tx.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While
                Dim com As StreamReader = New StreamReader("hints/commands.txt")
                While com.Peek <> -1
                    Dim an As String = com.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While
                Dim j As StreamReader = New StreamReader("hints/bg.txt")
                While j.Peek <> -1
                    Dim an As String = j.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While
                Dim cg As StreamReader = New StreamReader("hints/cg.txt")
                While cg.Peek <> -1
                    Dim an As String = cg.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While
                Dim music As StreamReader = New StreamReader("hints/music.txt")
                While music.Peek <> -1
                    Dim an As String = music.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While

                Dim sprites As StreamReader = New StreamReader("hints/sprites.txt")
                While sprites.Peek <> -1
                    Dim an As String = sprites.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While
                Dim ambience As StreamReader = New StreamReader("hints/ambience.txt")
                While ambience.Peek <> -1
                    Dim an As String = ambience.ReadLine
                    If InStr(an, st, CompareMethod.Text) Then
                        hints.Items.Add(an)
                    End If
                End While
                '    usc.Close()
                j.Close()
                ambience.Close()
                com.Close()
                cg.Close()
                music.Close()
                sprites.Close()
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
    Shared Function BitmapToImage(ByVal btm As Bitmap) As BitmapImage 'Преобразование Bitmap к ImageSource
        Dim ms As New MemoryStream()
        CType(btm, Bitmap).Save(ms, Imaging.ImageFormat.Bmp)
        Dim image As New BitmapImage()
        image.BeginInit()
        ms.Seek(0, SeekOrigin.Begin)
        image.StreamSource = ms
        image.EndInit()
        Return image
    End Function
    Private Sub num_SelectionChanged(sender As Object, e As RoutedEventArgs) Handles num.MouseUp
        Try
            code.SelectionStart = code.GetCharacterIndexFromLineIndex(num.SelectedIndex)
            code.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub hints_SelectionChanged(sender As Object, e As RoutedEventArgs) Handles hints.SelectionChanged
        Try
            Dim SelectedHint As String = Replace(hints.SelectedItem, "    ", "")
            Select Case Get_Word(1, SelectedHint)
                Case "scene"
                    Show_bg(SelectedHint)
                Case "show"
                    Show_cg(SelectedHint)
                Case "play"
                    Play_audio(SelectedHint)
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Show_bg(ByVal bg_adr As String)
        Dim addr As String = Replace(bg_adr, "scene bg ", "")
        MsgBox(Directory.GetCurrentDirectory + "\bg\" + addr + ".jpg")
        preView.Source = BitmapToImage(Image.FromFile(Directory.GetCurrentDirectory + "\bg\" + addr + ".jpg"))

    End Sub
    Private Sub Show_cg(ByVal cg_adr As String)
        If InStr(cg_adr, "show cg ") > -1 Then
            Dim addr As String = Replace(cg_adr, "show cg ", "")
            MsgBox(Directory.GetCurrentDirectory + "\cg\" + addr + ".jpg")
            preView.Source = BitmapToImage(Image.FromFile(Directory.GetCurrentDirectory + "\cg\" + addr + ".jpg"))
        Else
            Dim addr As String = Replace(cg_adr, "show ", "")
            MsgBox(Directory.GetCurrentDirectory + "\sprites\" + addr + ".jpg")
            preView.Source = BitmapToImage(Image.FromFile(Directory.GetCurrentDirectory + "\sprites\" + addr + ".png"))
        End If
    End Sub
    Private Sub Play_audio(ByVal playnow As String)
        'TODO воспроизведение звуков
    End Sub
    Private Function Get_Word(ByVal a As Integer, ByVal str As String)
        Dim WrdArr() As String = Split(str)
        Dim i As Integer = 1
        For Each Word In WrdArr
            If i = a Then
                Return Word
            End If
            i += 1
        Next
    End Function
    Private Sub Resize_elem() Handles Me.SizeChanged
        'TODO - здесь нужно сделать отрисовку интерфейса в соответствии с размером окна
    End Sub
End Class
