using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    [DataContract]
    public class Base<T> where T:Base<T>
    {
        [DataMember(Name = "Items")]
        public static Dictionary<Guid, T> Items;
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Id")]
        public Guid Id { get; private set; }
        public Base(string name)
        {
            Id = Guid.NewGuid();
            if(Items==null)
            {
                Items = new Dictionary<Guid, T>();
            }
            Items.Add(Id, (T)this);
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
