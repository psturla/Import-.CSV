Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFile.Enabled = False

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        'Traer directorio
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Multiselect = False

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sName As String = OpenFileDialog1.SafeFileName
            txtFile.Text = OpenFileDialog1.FileName

            'Dim directory As String = System.Configuration.ConfigurationManager.AppSettings.Get("Dir")

            ' Import CSV
            Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(txtFile.Text)

            TextFileReader.TextFieldType = FileIO.FieldType.Delimited
            TextFileReader.SetDelimiters(ChrW(1))

            Dim TextFileTable As DataTable = Nothing

            Dim Column As DataColumn
            Dim Row As DataRow
            Dim UpperBound As Int32
            Dim ColumnCount As Int32
            Dim CurrentRow As String()
            Dim firstRow As Boolean = True

            While Not TextFileReader.EndOfData
                Try
                    CurrentRow = TextFileReader.ReadFields()
                    If Not CurrentRow Is Nothing Then
                        If TextFileTable Is Nothing Then
                            TextFileTable = New DataTable("TextFileTable")
                            UpperBound = CurrentRow.GetUpperBound(0)
                            For ColumnCount = 0 To UpperBound
                                Column = New DataColumn()
                                Column.DataType = System.Type.GetType("System.String")
                                Column.ColumnName = CurrentRow(ColumnCount).ToString
                                Column.Caption = CurrentRow(ColumnCount).ToString
                                Column.ReadOnly = True
                                Column.Unique = False
                                TextFileTable.Columns.Add(Column)
                            Next
                        End If
                        Row = TextFileTable.NewRow
                        If Not firstRow Then
                            For ColumnCount = 0 To UpperBound
                                Row(ColumnCount) = CurrentRow(ColumnCount).ToString
                            Next
                            TextFileTable.Rows.Add(Row)
                        End If
                        firstRow = False
                    End If
                Catch ex As _
                Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Error en la linea: " & ex.Message)
                End Try
            End While
            TextFileReader.Dispose()
            grdCsv.DataSource = TextFileTable

        End If


    End Sub
End Class
