Module Module1
    'urutan function nya
    Sub main()
        buat_file()
        baca_file()
    End Sub

    'function create file
    Sub buat_file()
        Dim filepath As String = "C:\Users\L13\Documents\readme.txt"
        Dim content As String = "terms and condition"

        IO.File.WriteAllText(filepath, content)

        Dim tanya = MsgBox("File teks berhasil dibuat. Mau lihat isi file?", MsgBoxStyle.YesNo)
        If tanya = MsgBoxResult.Yes Then
            baca_file()
        Else
            End
        End If
    End Sub

    'function read file
    Sub baca_file()
        Dim filepath As String = "C:\Users\L13\Documents\readme.txt"

        If IO.File.Exists(filepath) Then
            Dim read As String = IO.File.ReadAllText(filepath)
            MsgBox("Isi file ini adalah : " & vbCrLf & read)
        Else
            MsgBox("File tidak ditemukan")
        End If
    End Sub

End Module
