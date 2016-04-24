using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public class Employee : Base<Employee>
    {
        public Employee(string name, string surname) : base(name)
        {
            Surname = surname;
        }
        public string Surname { get; private set; }
        public Workplace Workplace { get; private set; }
        public int Salary { get; set; }
        private List<double> _salaries = new List<double>();
        public ReadOnlyCollection<double> Salaries { get { return _salaries.AsReadOnly(); } private set { } }
        public void Paid()
        {
            if (_salaries == null)
            {
                _salaries = new List<double>();
            }
            _salaries.Add(Salary);
            Salary = 0;
        }
        public void SetWorkplace(Workplace w)
        {
            this.Workplace = w;
        }
    }
}
