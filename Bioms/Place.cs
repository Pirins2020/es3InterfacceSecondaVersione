using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Bioms
{
    public class Place
    {
        public Biom foresta = new Biom("foresta", "cioa iiufrjf");

        internal Place()
        {
            foresta.AddObject();
        }
    }
}
