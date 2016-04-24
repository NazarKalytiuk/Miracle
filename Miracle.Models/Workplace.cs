using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public class Workplace : Base<Workplace>
    {
        private List<Employee> _employees;
        public int Pay { get; set; }
        public List<Material> InputMaterials { get; set; }
        public List<Material> OutputMaterials { get; set; }
        public Workplace(string name, int pay, List<Employee> employees, List<Material> input, List<Material> output) : base(name)
        {
            foreach (var empl in employees)
            {
                empl.SetWorkplace(this);
            }
            _employees = employees;
            InputMaterials = input;
            OutputMaterials = output;
            Pay = pay;
        }
        public void AddEmployee(Employee empl)
        {
            empl.SetWorkplace(this);
            _employees.Add(empl);
        }
        public ReadOnlyCollection<Employee> GetEmployees
        {
            get { return _employees.AsReadOnly(); }
            private set { }
        }
        public override string ToString()
        {
            return Name;
        }
        public void Make()
        {
            foreach (var item in InputMaterials)
            {
                //Storage.Materials.Find(i => i == item).Count--;
            }
            foreach (var item in OutputMaterials)
            {
                //Storage.Materials.Find(i => i == item).Count++;
            }
            foreach (var empl in _employees)
            {
                empl.Salary += Pay;
            }
        }
    }
}
