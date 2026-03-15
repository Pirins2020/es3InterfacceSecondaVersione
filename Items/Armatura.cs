using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Items
{
    public class Armatura 
    {
        public string Name { get; set; }
        public int Protection { get; set; }
        
        public Armatura(string name, int protection)
        {
            Name = name;
            Protection = protection;
            
        }

        
    }
}
