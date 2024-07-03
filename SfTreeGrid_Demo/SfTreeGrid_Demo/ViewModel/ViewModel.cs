using SfTreeGrid_Demo.Model;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfTreeGrid_Demo.ViewModel
{
    public class ViewModel : NotificationObject
    {

        public ViewModel()
        {
            this.Employees = this.GetEmployees();
        }
        private ObservableCollection<EmployeeInfo> _employees;

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _employees; }
            set 
            { 
                _employees = value;
                RaisePropertyChanged("Employees");
            }
        }

        private ObservableCollection<EmployeeInfo> GetEmployees()
        {
            ObservableCollection<EmployeeInfo> employeeDetails = new ObservableCollection<EmployeeInfo>();
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Ferando", BasicPay = 100, Reduction = 50, Salary = 50, ReportsTo = -1, ID = 2 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "John", BasicPay = 200, Reduction = 50, Salary = 150, ReportsTo = -1, ID = 3 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Thomas", BasicPay = 300, Reduction = 50, Salary = 250, ReportsTo = -1, ID = 4 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Andrew", BasicPay = 100, Reduction = 50, Salary = 50, ReportsTo = -1, ID = 5 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Ulysses", BasicPay = 400, Reduction = 50, Salary = 350, ReportsTo = -1, ID = 6 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Jimmy", BasicPay = 500, Reduction = 50, Salary = 450, ReportsTo = -1, ID = 7 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Ronald", BasicPay = 600, Reduction = 50, Salary = 550, ReportsTo = -1, ID = 8 });
            ////Management

            employeeDetails.Add(new EmployeeInfo() { FirstName = "Andrew", BasicPay = 200, ID = 9, Salary = 150, ReportsTo = 2, Reduction = 50 });

            //Accounts
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Nancy", BasicPay = 900, ID = 12, Salary = 850, ReportsTo = 3, Reduction = 50 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Margaret", BasicPay = 100, ID = 13, Salary = 50, ReportsTo = 3, Reduction = 50 });

            //Sales
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Laura", BasicPay = 1000, ID = 16, Salary = 750, ReportsTo = 4, Reduction = 250 });

            //Back Office
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Caroline", BasicPay = 1000, ID = 21, Salary = 750, ReportsTo = 5, Reduction = 250 });
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Xavier", BasicPay = 1000, ID = 22, Salary = 650, ReportsTo = 5, Reduction = 350 });

            //HR
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Laurent", BasicPay = 750, ID = 23, Salary = 700, ReportsTo = 6, Reduction = 50 });

            //Purchasing
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Pamela", BasicPay = 800, ID = 26, Salary = 750, ReportsTo = 7, Reduction = 50 });

            //Production
            employeeDetails.Add(new EmployeeInfo() { FirstName = "Jillian", BasicPay = 200, ID = 29, Salary = 150, ReportsTo = 8, Reduction = 50 });

            return employeeDetails;
        }
    }
}
