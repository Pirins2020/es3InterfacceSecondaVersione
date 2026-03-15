using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Character
{
    public class Character(string name)
    {


        public string Name { get; set; } = name;
        public int InitialStrenght { get; set; }
        public int MaxLife { get; set; }
        public int Damage { get; set; }
    }
}
