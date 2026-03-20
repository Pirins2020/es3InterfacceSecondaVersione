using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Character
{
    public class Hero
    {
        public Uman duke = new Uman ("Duke", true, true);
        public Uman knite = new Uman ("Knite", false, true);
        public Uman servant = new Uman ("Servant", false, false);
        public Uman guard = new Uman ("Guard", false, false);
        public Uman Feudatary = new Uman ("Feudatary", false, false);

    }
}
