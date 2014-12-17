Public Class Form1
    
    Private Sub btnThrow_Click(sender As Object, e As EventArgs) Handles btnThrow.Click
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3
        Dim intComThrow As Integer
        Dim strName As String = Me.txtName.Text

        Randomize()
        intComThrow = Int((3 - 1 + 1) * Rnd() + 1)

        Select Case intComThrow
            Case intRock
                Select Case Me.rdoRock.Checked
                    Case True
                        Me.lblResult.Text = "Rock Vs. Rock, Tie"
                    Case False
                        'Do Nothing
                End Select
                Select Case Me.rdoPaper.Checked
                    Case True
                        Me.lblResult.Text = "Paper Covers Rock, " & strName & " Wins"
                    Case False
                        'Do Nothing
                End Select
                Select Case Me.rdoScissors.Checked
                    Case True
                        Me.lblResult.Text = "Rock Smashes Scissors, Computer Wins"
                End Select
            Case intPaper
                Select Case Me.rdoRock.Checked
                    Case True
                        Me.lblResult.Text = "Paper Covers Rock, Computer Wins"
                    Case False
                        'Do Nothing
                End Select
                Select Case Me.rdoPaper.Checked
                    Case True
                        Me.lblResult.Text = "Paper Vs. Paper, Tie"
                    Case False
                        'Do Nothing
                End Select
                Select Case Me.rdoScissors.Checked
                    Case True
                        Me.lblResult.Text = "Scissors Cut Paper, " & strName & " Wins"
                    Case False
                        'Do Nothing
                End Select
            Case intScissors
                Select Case Me.rdoRock.Checked
                    Case True
                        Me.lblResult.Text = "Rock Smashes Scissors, " & strName & " Wins"
                    Case False
                        'Do Nothing
                End Select
                Select Case Me.rdoPaper.Checked
                    Case True
                        Me.lblResult.Text = "Scissors Cut Paper, Computer Wins"
                    Case False
                        'Do Nothing
                End Select
                Select Case Me.rdoScissors.Checked
                    Case True
                        Me.lblResult.Text = "Scissors Vs. Scissors, Tie"
                    Case False
                        'Do Nothing
                End Select
        End Select
    End Sub
End Class
