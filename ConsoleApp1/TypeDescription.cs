using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TypeDescription
    {
        public int slot { get; set; }

        public TypeURL type { get; set; }

        public override string ToString()
        {
            return type.ToString();
        }
    }

}
