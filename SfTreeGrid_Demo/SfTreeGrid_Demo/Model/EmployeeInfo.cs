using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfTreeGrid_Demo.Model
{
    public class EmployeeInfo : NotificationObject
    {
        int _id;
        string _firstName;
        double? _basicPay;
        double? _reduction;
        double? _salary;
        int _reportsTo;

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                _firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public double? BasicPay
        {
            get { return _basicPay; }
            set 
            { 
                _basicPay = value;
                RaisePropertyChanged("BasicPay");
            }
        }

        public int ID
        {
            get { return _id; }
            set 
            { 
                _id = value;
                RaisePropertyChanged("ID");
            }
        }

        public double? Reduction
        {
            get { return _reduction; }
            set 
            { 
                _reduction = value;
                RaisePropertyChanged("Reduction");
            }
        }

        public double? Salary
        {
            get { return _salary; }
            set 
            { 
                _salary = value;
                RaisePropertyChanged("Salary");
            }
        }

        public int ReportsTo
        {
            get { return _reportsTo; }
            set 
            {
                _reportsTo = value;
                RaisePropertyChanged("ReportsTo");
            }
        }
    }
}
