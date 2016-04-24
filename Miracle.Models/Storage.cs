using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miracle.Models
{
    public class Storage
    {
        static List<Material> _materials;

        public static List<Material> Materials
        {
            get
            {
                if (_materials == null)
                {
                    _materials = new List<Material>();
                }
                return _materials;
            }
        }
    }
}
