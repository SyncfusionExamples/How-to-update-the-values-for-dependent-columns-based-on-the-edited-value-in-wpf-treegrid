In [WPF SfTreeGrid](https://www.syncfusion.com/wpf-controls/treegrid){target="_blank"}, we can achieve this by using the CurrentCellValidated event. In this event, we can fetch the current cell row data value; based on a condition, we can update the required column value.

**Please Refer the code snippet :**
 
 ```csharp
public MainWindow()
{
    InitializeComponent();
    this.treeGrid.CurrentCellValidated += TreeGrid_CurrentCellValidated;
}

private void TreeGrid_CurrentCellValidated(object sender, TreeGridCurrentCellValidatedEventArgs e)
{
    if (e.RowData != null && (e.Column.MappingName == "BasicPay" || e.Column.MappingName == "Reduction"))
    {
        var reduction = (e.RowData as EmployeeInfo).Reduction;
        var basicPay = (e.RowData as EmployeeInfo).BasicPay;
        (e.RowData as EmployeeInfo).Salary = basicPay - reduction;
    }                        
} 
 ```

**Output:**
  
 ![c2zBvcs8AX.gif](https://support.syncfusion.com/kb/agent/attachment/article/16474/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI1MDIxIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.dGOv_49CZyFOdhSj2D2f8ALQNuP0sNWpEDPOPSfJYwA)
 
 

Take a moment to peruse the [WPF-SfTreeGrid Data Validation](https://help.syncfusion.com/wpf/treegrid/data-validation){target="_blank"}, to learn more about the Data Validation with examples.
