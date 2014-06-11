Public Class Format
#Region "FontFamily"
    Public FontScale As Integer
    Public currentFont As System.Drawing.Font
    Public newFontStyle As System.Drawing.FontStyle
    Public fontSize() As String
#End Region


    Private Sub Format_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModifyFontFamily.FontSize_Family()
        ModifyFontFamily.Load_Pre()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RichTextBox2.Font = New Font("AaBbCcDdEeFf", ComboBox1.SelectedItem, FontStyle.Regular)
        FontScale = ComboBox1.SelectedItem
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModifyFontFamily.Font_Change()
    End Sub

    Public Sub Form_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Form1.ToolStripProgressBar1.Value = (0)
        Form1.Focus()
    End Sub
End Class