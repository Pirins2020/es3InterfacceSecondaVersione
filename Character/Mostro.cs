using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Character
{
    public class Mostro
    {
        public Goblin goblin = new Goblin("Goblin");
        public Vampire vampire = new Vampire("Vampire");
        public Mostro()
        { 
            goblin.assignRandomWeapon();
            vampire.assignRandomWeapon();
        }
    }
}
