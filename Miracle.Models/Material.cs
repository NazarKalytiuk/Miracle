using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public enum MaterialType : uint
    {
        Sosna,
        Dub,
        Yasen
    }
    [DataContract]
    public class Material : Base<Material>
    {
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public MaterialType Type { get; private set; }
        public Material(string name, MaterialType type) : base(name)
        {
            Type = type;
        }
    }
}
