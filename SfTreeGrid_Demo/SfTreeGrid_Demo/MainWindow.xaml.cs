using SfTreeGrid_Demo.Model;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfTreeGrid_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
    }  
        
}
