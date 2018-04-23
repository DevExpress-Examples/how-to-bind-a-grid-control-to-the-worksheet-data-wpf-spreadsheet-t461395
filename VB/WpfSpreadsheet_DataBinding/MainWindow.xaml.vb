Imports DevExpress.Spreadsheet
Imports System
Imports System.Globalization
Imports System.Windows

Namespace WpfSpreadsheet_DataBinding
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            spreadsheet.Options.Culture = New CultureInfo("en-US")
            spreadsheet.LoadDocument("Documents/Expenses_template.xlsx", DocumentFormat.Xlsx)
        End Sub

        Private Sub spreadsheet_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
'            #Region "#BindGridToSpreadsheetTable"
            Dim workbook As IWorkbook = spreadsheet.Document
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            ' Access the table on the worksheet. 
            Dim expensesTable As Table = worksheet.Tables(0)
            ' Specify the data source settings.
            Dim options As New RangeDataSourceOptions()
            options.PreserveFormulas = True
            options.SkipHiddenRows = True
            ' Bind the grid control to the table data.
            grid.ItemsSource = expensesTable.DataRange.GetDataSource(options)
'            #End Region ' #BindGridToSpreadsheetTable
        End Sub
    End Class
End Namespace
