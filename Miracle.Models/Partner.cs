using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public abstract class Partner : Base<Partner>
    {
        public Partner(string name, string surname) : base(name)
        {
            Surname = surname;
        }
        public string Surname { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Surname);
        }
    }
}
