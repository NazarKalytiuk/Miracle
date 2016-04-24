using System;
using System.Collections.Generic;
using Miracle.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Miracle.Commons;
using System.Windows.Controls;
using Miracle.ServiceReference1;

namespace Miracle.ViewModels
{
    class PersonalViewModel : ViewModelBase
    {
        public Dictionary<Guid, Employee>.ValueCollection Employees { get { return Base<Employee>.Items.Values; } set { } }
        public Dictionary<Guid, Workplace>.ValueCollection Workplaces { get { return  Base<Workplace>.Items.Values; } set { } }
        public string NewEmployeeName { get; set; }
        public string NewEmployeeSurname { get; set; }
        public Workplace NewEmployeeWorkplace { get; set; }
        public ICommand AddCommand { get; }
        public PersonalViewModel()
        {
            AddCommand = new RelayCommand(AddEmployee);
        }
        public void AddEmployee(object obj)
        {
            Employee e = new Employee(NewEmployeeName, NewEmployeeSurname);
            e.SetWorkplace(NewEmployeeWorkplace);
            Employees = Base<Employee>.Items.Values;
            ((DataGrid)obj).Items.Refresh();
            OnPropertyChanged("Employees");
        }
    }
}
