using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public class Customer : Partner
    {
        public Customer(string name, string surname) : base(name, surname)
        {
        }

        public DateTime Deadline { get; set; }
        public void SetOrder(List<Material> order)
        {
            foreach (var item in order)
            {
                Storage.Materials.Find(w => w == item).Count -= item.Count;
            }
        }
    }
}
