Module ModifyFontFamily
    Public Sub Font_Change()
        Dim SaveFormat As String
        SaveFormat = (MessageBox.Show("Are You Sure You Would Like To Save Font Settings?", "Raven Font", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        If SaveFormat = DialogResult.Yes Then
            Form1.RichTextBox1.SelectionFont = New Font( _
                    Format.currentFont.FontFamily, _
                    Format.FontScale, _
                    Format.newFontStyle _
                  )
            Form1.ToolStripProgressBar1.Value = (0)
            Format.Hide()
        Else
        End If
    End Sub

#Region "FontSizeCombo"
    Public Sub FontSize_Family()
        Format.fontSize = New String() _
        {"8", "10", "12", _
         "14", "16", "18", _
         "20", "22", "24", _
         "26", "28", "30"}
        Format.ComboBox1.Items.AddRange(Format.fontSize)
        Format.ComboBox1.SelectedItem = ("12")
    End Sub
#End Region

#Region "Load Pre"
    Public Sub Load_Pre()
        Format.RichTextBox2.Font = New Font("AaBbCcDdEeFf", Format.ComboBox1.SelectedItem, FontStyle.Regular)
        Format.currentFont = Form1.RichTextBox1.SelectionFont
        Format.newFontStyle = FontStyle.Regular


    End Sub
#End Region

End Module
