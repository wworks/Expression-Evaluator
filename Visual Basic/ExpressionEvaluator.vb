Module ExpressionEvaluator
    Dim Digits() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Dim opPlus As Char = "+"
    Dim opMinus As Char = "-"
    Dim opTimes As Char = "*"
    Dim opDivide As Char = "/"
    Dim haop As Char = "("
    Dim hacl As Char = ")"

    Sub Main()
        While True
            Console.Clear()
            Console.WriteLine("Enter you expression:   Possible operators: * / + - brackets supported.")
            Dim expression = Console.ReadLine
            If expression <> "" Then
                Try
                    Console.WriteLine(Parser(expression))
                Catch ex As Exception
                    Console.WriteLine("Something went wrong, is your expression correct?")
                End Try

                Console.WriteLine("Press enter to do another expression.")
                Console.Read()
            End If
        End While
    End Sub
    Private Function Parser(Expression As String) As Double
        Dim ExpressionList As New List(Of String)
        Dim possibleOperators As New List(Of Char)
        Dim NumberOfBrackets As Integer = 0
        Dim temp As String = ""
        Dim prevLetter As Char = ""

        For i As Integer = 0 To Expression.Length - 1
            Dim letter As Char = Expression(i)
            Dim IsDone As Boolean = False
            If Digits.Contains(letter) Then
                temp &= letter
                IsDone = True
            ElseIf haop = letter Then
                NumberOfBrackets += 1
                temp &= letter
                IsDone = True 
            ElseIf hacl = letter Then
                NumberOfBrackets -= 1
                IsDone = True
                temp &= letter
            ElseIf letter = "," Then
                Console.WriteLine("Use dots for comma's")
                temp &= ","
                IsDone = True
            ElseIf letter = "." Then
                temp &= ","
                IsDone = True
            Else
                If Not NumberOfBrackets = 0 Then
                    temp &= letter
                    IsDone = True
                End If
            End If
            If IsDone = False Then
                Dim letterIsOperator As Boolean = letter = opPlus Or letter = opMinus Or letter = opTimes Or letter = opDivide
                Dim PrevletterIsOperator As Boolean = prevLetter = opPlus Or prevLetter = opMinus Or prevLetter = opTimes Or prevLetter = opDivide


                If letterIsOperator And PrevletterIsOperator = False And prevLetter <> "" Then
                    If prevLetter = hacl Then
                        Dim newExpression = temp.Remove(0, 1)
                        newExpression = newExpression.Remove(newExpression.Length - 1)
                        ExpressionList.Add(Parser(newExpression))
                    Else
                        ExpressionList.Add(temp)
                    End If
                    possibleOperators.Add(letter)
                    ExpressionList.Add(letter)
                    temp = ""
                End If
            End If
            prevLetter = letter
        Next
        If temp <> "" Then
            If prevLetter = hacl Then
                Dim newExpression = temp.Remove(0, 1)
                newExpression = newExpression.Remove(newExpression.Length - 1)
                ExpressionList.Add(Parser(newExpression))
            Else
                ExpressionList.Add(temp)
            End If
        End If
        Return CalculateExpression(ExpressionList, possibleOperators)
    End Function
    Private Function CalculateExpression(ExpressionList As List(Of String), possibleOperators As List(Of Char)) As Double
        If ExpressionList.Count = 3 Then
            If Not (ExpressionList(0).Contains(haop) Or ExpressionList(1).Contains(haop) Or ExpressionList(2).Contains(haop)) Then
                Select Case ExpressionList(1)
                    Case opTimes
                        Return CDbl(ExpressionList(0)) * CDbl(ExpressionList(2))
                    Case opDivide
                        Return CDbl(ExpressionList(0)) / CDbl(ExpressionList(2))
                    Case opPlus
                        Return CDbl(ExpressionList(0)) + CDbl(ExpressionList(2))
                    Case opMinus
                        Return CDbl(ExpressionList(0)) - CDbl(ExpressionList(2))
                End Select
            End If
        End If

        possibleOperators.Sort()
        Dim index = 0
        While possibleOperators.BinarySearch(opTimes) > 0 Or possibleOperators.BinarySearch(opDivide) > 0
            index = 1
            While index <> ExpressionList.Count And ExpressionList.Count <> 1
                If ExpressionList(index) = opTimes Then
                    possibleOperators.Remove(opTimes)
                    ExpressionList(index - 1) = CDbl(ExpressionList(index - 1)) * CDbl(ExpressionList(index + 1))
                    ExpressionList.RemoveRange(index, 2)
                    index -= 2
                ElseIf ExpressionList(index) = opDivide Then
                    possibleOperators.Remove(opDivide)
                    ExpressionList(index - 1) = CDbl(ExpressionList(index - 1)) / CDbl(ExpressionList(index + 1))
                    ExpressionList.RemoveRange(index, 2)
                    index -= 2
                End If
                index += 2

            End While
        End While
        While possibleOperators.BinarySearch(opMinus) > 0 Or possibleOperators.BinarySearch(opPlus) > 0
            index = 1
            While index <> ExpressionList.Count And ExpressionList.Count <> 1

                If ExpressionList(index) = opPlus Then
                    possibleOperators.Remove(opPlus)
                    ExpressionList(index - 1) = CDbl(ExpressionList(index - 1)) + CDbl(ExpressionList(index + 1))
                    ExpressionList.RemoveRange(index, 2)
                    index -= 2
                ElseIf ExpressionList(index) = opMinus Then
                    possibleOperators.Remove(opMinus)
                    ExpressionList(index - 1) = CDbl(ExpressionList(index - 1)) - CDbl(ExpressionList(index + 1))
                    ExpressionList.RemoveRange(index, 2)
                    index -= 2
                End If
                index += 2
            End While
        End While
        Return ExpressionList(0)
    End Function
End Module
