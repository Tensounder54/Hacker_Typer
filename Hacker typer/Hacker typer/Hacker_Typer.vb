Imports System
Imports System.IO

'<HostProtectionAttribute(SecurityAction.LinkDemand, UI:=True)>
'Public Shared Function ReadKey() As ConsoleKeyInfo

Module Hacker_Typer

    'Public Shared Function Open(
    '        path As B:\Documents\hacker_typer_txt.txt,
    '        mode As 'read',
    '        ) As FileStream
    'End Function

    Sub Main()

        Dim speed As Integer
        'Dim line As String

        Try
            ' Open the file using a stream reader.
            Using sr As New StreamReader("B:\Documents\Hacker typer\Hacker typer\hacker_typer_txt.txt")
                Dim line As String
                ' Read the stream to a string and write the string to the console.
                line = sr.ReadToEnd()
                Dim words As String() = line.Split(New Char() {" "c})
                'Dim e As KeyPressEventArgs
                Dim word As String
                For Each word In words
                    If Console.ReadKey(True).Key <> ConsoleKey.Escape Then 'Console.KeyAvailable
                        Console.Write(word + " ")
                    ElseIf Console.ReadKey(True).Key = ConsoleKey.Escape Then
                        Environment.Exit(0)
                    End If
                Next

            End Using
        Catch e As Exception
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try



        Console.ReadLine()

    End Sub



End Module
