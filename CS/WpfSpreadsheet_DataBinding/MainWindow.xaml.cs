using DevExpress.Spreadsheet;
using System;
using System.Globalization;
using System.Windows;

namespace WpfSpreadsheet_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            spreadsheet.Options.Culture = new CultureInfo("en-US");
            spreadsheet.LoadDocument(@"Documents/Expenses_template.xlsx", DocumentFormat.Xlsx);
        }

        void spreadsheet_DocumentLoaded(object sender, EventArgs e)
        {
            #region #BindGridToSpreadsheetTable
            IWorkbook workbook = spreadsheet.Document;
            Worksheet worksheet = workbook.Worksheets[0];
            // Access the table on the worksheet. 
            Table expensesTable = worksheet.Tables[0];
            // Specify the data source settings.
            RangeDataSourceOptions options = new RangeDataSourceOptions();
            options.PreserveFormulas = true;
            options.SkipHiddenRows = true;
            // Bind the grid control to the table data.
            grid.ItemsSource = expensesTable.DataRange.GetDataSource(options);
            #endregion #BindGridToSpreadsheetTable
        }
    }
}
