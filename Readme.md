<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfSpreadsheet_DataBinding/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/WpfSpreadsheet_DataBinding/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/WpfSpreadsheet_DataBinding/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfSpreadsheet_DataBinding/MainWindow.xaml.vb))
<!-- default file list end -->
# How to bind a grid control to the worksheet data (WPF Spreadsheet)


<p>This example demonstrates how to bind the <a href="https://documentation.devexpress.com/#WPF/CustomDocument6084">Grid Control</a> to the <a href="https://documentation.devexpress.com/#WPF/CustomDocument16118">Spreadsheet</a> data. To do this, use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressSpreadsheetRange_GetDataSourcetopic">Range.GetDataSource</a> method to create a data source object from a specific cell range in a worksheet, and then assign it to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfGridDataControlBase_ItemsSourcetopic">GridControl.ItemsSource</a> property. The two-way binding is supported: any changes to worksheet (such as editing values, inserting and deleting rows, sorting and filtering) are immediately propagated to the Data Grid, and editing data in the grid is reflected in the spreadsheet.</p>

<br/>


