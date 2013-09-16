Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        'Read the input from the user
        fullname = txtFullName.Text

        'Trim the input so as to remove leading spaces - use the Trim function to remove spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Find the index of first name - find the first space in the trimmed version
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'Extract the first name
        Dim firstname As String
        firstname = fullnameTrimmed.Substring(0, idxSpace)

        'Display the result to the user
        txtFirstName.Text = firstname


    End Sub
End Class
