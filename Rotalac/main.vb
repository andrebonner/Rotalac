Public Class CalPadForm
    Private evalString, lastOp As String
    Private lastValue, kValue, mValue As String
    Private resultValue As String
    Private opPresent, neg As Boolean

    Private Sub CalPadForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub CalPadForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

    End Sub

    Private Sub CalPadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opPresent = False ' is a operator present
        neg = False ' is number negative
    End Sub


    Private Sub backspaceBtn_Click(sender As Object, e As EventArgs) Handles backspaceBtn.Click
        ' backspace from keyboard
        lastValue = lastValue.Substring(0, lastValue.Length - 1)
        CalText.Text = CalText.Text.Substring(0, CalText.Text.Length - 1)
    End Sub

    Private Sub ceBtn_Click(sender As Object, e As EventArgs) Handles ceBtn.Click
        ' clear current entry
        kValue = ""
        CalText.Text = "0"
    End Sub

    Private Sub cBtn_Click(sender As Object, e As EventArgs) Handles cBtn.Click
        ' clear all
        kValue = ""
        mValue = ""
        lastValue = ""
        evalString = ""
        resultValue = ""
        opPresent = False
        lastOp = ""
        CalText.Text = "0"
    End Sub

    Private Sub mcBtn_Click(sender As Object, e As EventArgs) Handles mcBtn.Click
        ' memory clear
    End Sub

    Private Sub mrBtn_Click(sender As Object, e As EventArgs) Handles mrBtn.Click
        ' memory recall
    End Sub

    Private Sub msBtn_Click(sender As Object, e As EventArgs) Handles msBtn.Click
        ' memory subtract
    End Sub

    Private Sub mpBtn_Click(sender As Object, e As EventArgs) Handles mpBtn.Click
        ' memory add
    End Sub

    Private Sub sqrtBtn_Click(sender As Object, e As EventArgs) Handles sqrtBtn.Click
        'square root of number
        evalString &= Convert.ToString(Convert.ToDouble(Math.Sqrt(lastValue)))
        resultValue = evalString

        CalText.Text = resultValue
    End Sub

    Private Sub percentBtn_Click(sender As Object, e As EventArgs) Handles percentBtn.Click
        'percentage
        evalString &= lastValue + "%"
        resultValue = Evaluate(evalString)

        CalText.Text = resultValue
    End Sub

    Private Sub oneoverBtn_Click(sender As Object, e As EventArgs) Handles oneoverBtn.Click
        ' reciprocal
        evalString = "1/" + lastValue
        resultValue = Evaluate(evalString)
        CalText.Text = resultValue
    End Sub

    Private Sub zeroBtn_Click(sender As Object, e As EventArgs) Handles zeroBtn.Click
        If Convert.ToDecimal(kValue) <> 0 Then
            numberEntry("0")
        End If
    End Sub

    Private Sub oneBtn_Click(sender As Object, e As EventArgs) Handles oneBtn.Click
        numberEntry("1")
    End Sub

    Private Sub twoBtn_Click(sender As Object, e As EventArgs) Handles twoBtn.Click
        numberEntry("2")
    End Sub

    Private Sub threeBtn_Click(sender As Object, e As EventArgs) Handles threeBtn.Click
        numberEntry("3")
    End Sub

    Private Sub fourBtn_Click(sender As Object, e As EventArgs) Handles fourBtn.Click
        numberEntry("4")
    End Sub

    Private Sub fiveBtn_Click(sender As Object, e As EventArgs) Handles fiveBtn.Click
        numberEntry("5")
    End Sub

    Private Sub sixBtn_Click(sender As Object, e As EventArgs) Handles sixBtn.Click
        numberEntry("6")
    End Sub

    Private Sub sevenBtn_Click(sender As Object, e As EventArgs) Handles sevenBtn.Click
        numberEntry("7")
    End Sub

    Private Sub eightBtn_Click(sender As Object, e As EventArgs) Handles eightBtn.Click
        numberEntry("8")
    End Sub

    Private Sub nineBtn_Click(sender As Object, e As EventArgs) Handles nineBtn.Click
        numberEntry("9")
    End Sub

    Private Sub pmBtn_Click(sender As Object, e As EventArgs) Handles pmBtn.Click

        If neg = False Then
            Try
                Convert.ToString(Convert.ToDecimal("-" + lastValue))
                lastValue = "-" + lastValue
                CalText.Text = lastValue
                neg = True
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        Else
            lastValue = CalText.Text
            lastValue = lastValue.Substring(1, lastValue.Length - 1)
            CalText.Text = lastValue
            neg = False
        End If
        'evalString &= evalString
    End Sub

    Private Sub pointBtn_Click(sender As Object, e As EventArgs) Handles pointBtn.Click
        'is this a decimal number
        Try
            Convert.ToString(Convert.ToDecimal(lastValue + ".0"))
            evalString &= "."
            lastValue &= "."
            CalText.Text = lastValue
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Debug.WriteLine(evalString)
    End Sub

    Sub opEntry()
        If mValue <> "" Then
            mValue = ""
            resultValue = Evaluate(evalString)
            kValue = resultValue

        Else
            lastValue = ""
        End If
        evalString &= lastOp
        opPresent = True
        Debug.WriteLine(evalString)
    End Sub
    Private Sub plusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click
        lastOp = "+"
        opEntry()
    End Sub

    Private Sub minusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        lastOp = "-"
        opEntry()
    End Sub

    Private Sub timesBtn_Click(sender As Object, e As EventArgs) Handles timesBtn.Click
        lastOp = "*"
        opEntry()
    End Sub

    Private Sub divideBtn_Click(sender As Object, e As EventArgs) Handles divideBtn.Click
        lastOp = "/"
        opEntry()
    End Sub

    Function Evaluate(expression As String) As Double

        Dim table As System.Data.DataTable
        table = New System.Data.DataTable
        table.Columns.Add("expression", String.Empty.GetType, expression)
        Dim row As System.Data.DataRow
        row = table.NewRow
        table.Rows.Add(row)
        Return Double.Parse(row("expression").ToString)
    End Function

    Private Sub equalBtn_Click(sender As Object, e As EventArgs) Handles equalBtn.Click
        If opPresent Then
            opPresent = False
        End If
        If resultValue <> "" Then
            evalString = resultValue + lastOp + mValue
        End If
        ' evaluating the expression
        resultValue = Evaluate(evalString)
        CalText.Text = resultValue.ToString
        Debug.WriteLine(evalString + "=" + resultValue.ToString)
        evalString = ""
    End Sub
    Private Sub numberEntry(number As String)
        ' is the  
        If Not opPresent Then
            kValue = lastValue + number
            ' enters number
            CalText.Text = kValue
            lastValue = kValue

        Else
            mValue = lastValue + number
            ' enters number
            CalText.Text = mValue
            lastValue = mValue
        End If
        evalString &= Convert.ToString(Convert.ToDecimal(number))
        Debug.WriteLine(evalString)

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        CalText.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        CalText.Paste()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' show About Dialog
        about.ShowDialog()
    End Sub

    Private Sub ScientificViewStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificViewStripMenuItem.Click
        ' Scientific Mode
    End Sub

    Private Sub StandardViewStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardViewStripMenuItem.Click
        'Standard Mode
    End Sub

    Private Sub CalTest_DoubleClick(sender As Object, e As EventArgs) Handles CalTest.DoubleClick

    End Sub
End Class
