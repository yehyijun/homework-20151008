Module Module1

    Sub MAIN()
        Console.WriteLine("1,5,3 中最大數是{0}", _
                          getmax(1, 5, 3).ToSTRING())
        Console.WriteLine()
        Console.WriteLine("10,5,3,100,23中最大數是{0}", _
                          getmax(10, 5, 3, 100, 23).TOSTRING())
        Console.Read()
    End Sub

    Function getmax(ByVal ParamArray X() As Integer) As Integer
        Dim max As Integer
        max = X(0)
        For i As Integer = 1 To X.Length - 1
            If X(i) > max Then
                max = X(i)
            End If
        Next
        Return max
    End Function

End Module


