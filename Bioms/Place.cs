using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Bioms
{
    public class Place
    {
        public Biom foresta = new Biom("Foresta del Castello", "foresta del cstello");
        public Biom castello = new Biom("Castello", "castello del duca");
        public Biom feudo = new Biom("Feudo", "feudo del feudatario");
        public Biom villaggio = new Biom ("Villaggio", "villaggio libero");
        public Biom campo = new Biom("Campo", "vasta prateria");
        public Biom castelloDiDracula = new Biom("Castello di Dracula", "castello del vampiro");
        public Biom cavernaDelGoblin = new Biom("Caverna del Goblin", "caverna del goblin");
        

        internal Place()
        {
            foresta.AddObject();
            castello.AddObject();
            feudo.AddObject();
            villaggio.AddObject();
            campo.AddObject();
            castelloDiDracula.AddObject();
            cavernaDelGoblin.AddObject();

        }
    }
}
