Module Module1
    '   Title:          tryFizzBuzz
    '   Author:         A.Tafreed
    '   Version:        0.1
    '   Date:           6/10/2026
    '   Description:    Creating a simple FizzBuzz simulator
    Sub Main()
        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim divisor As Integer = 0

        '   output all of the multiples of 7 from num1 to num2
        Console.WriteLine("Please enter the first number")
        num1 = Console.ReadLine()
        Console.WriteLine("Please enter the second number")
        num2 = Console.ReadLine()
        Console.WriteLine("Please enter a divisor")
        divisor = Console.ReadLine()

        For counter = num1 To num2
            If counter Mod divisor = 0 Then
                Console.WriteLine(counter)
            End If
        Next


        '   Console.WriteLine("3 mod 8: " & 3 Mod 8)
        '   Console.WriteLine("5 mod 2: " & 5 Mod 2)
        '   Console.WriteLine("7 mod 2: " & 7 Mod 2)
        '   Console.WriteLine("4 mod 2: " & 4 Mod 2)
        '   Console.WriteLine("11 mod 10: " & 11 Mod 10)

        '   '   Mod is short for modulous it returns the remainder of a division
        '   Console.WriteLine("5 div 2: " & 5 \ 2) 'backslash, not / which is for division
        '   Console.WriteLine("10 div 2: " & 10 \ 2)
        '   Console.WriteLine("11 div 3: " & 11 \ 3)
        '   ' Div(\) returns the quotient of a division, the whole number part

        '   Dim mo As Integer = 0
        '   Dim di As Integer = 0

        '   mo = 12 Mod 3
        '   di = 12 \ 3

        '   Console.WriteLine("12 divided by 3 = " & di & " remainder " & mo)
    End Sub

End Module
