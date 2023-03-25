using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AbilityDescription
    {
        public AbilityURL ability { get; set; }
        public bool isHidden { get; set; }

        public int slot { get; set; }

        public override string ToString()
        {
            return ability.ToString();
        }


    }
}
