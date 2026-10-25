Imports System

Module Program
    Sub Main(args As String())
        Dim total As String = ""
        Dim strlen As Integer
        Dim tempstr1 As Char
        Dim tempstr2 As Char
        Dim tempint1 As Integer
        Dim tempint2 As Integer
        Dim count As Integer
        Console.WriteLine("enter a string of letters")
        total = Console.ReadLine()
        strlen = Len(total)

        Do
            count = 0
            tempstr1 = total.Substring(0, 1)
            For i = 0 To strlen - 2
                tempstr2 = total.Substring(i + 1, 1)
                tempint1 = AscW(tempstr1)
                tempint2 = AscW(tempstr2)
                If tempint1 < tempint2 Then
                    total += ChrW(tempint1)
                    tempstr1 = tempstr2
                ElseIf tempint2 < tempint1 Then
                    count += 1
                    total += ChrW(tempint2)
                ElseIf tempint1 = tempint2 Then
                    total += ChrW(tempint1)
                End If
            Next
            total += tempstr1
            total = total.Remove(0, strlen)
        Loop Until count = 0

        Console.WriteLine(total)
    End Sub
End Module
