using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public class Provider : Partner
    {
        public Provider(string name, string surname) : base(name, surname)
        {
        }

        public DateTime DeliveryTime { get; set; }
        public void GetDelivery(DateTime date, Material m)
        {
            Storage.Materials.Add(m);
        }
    }
}
