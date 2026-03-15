using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Items
{
    public class Arsenale
    {
        public ArmaCorpoACorpo spada = new ArmaCorpoACorpo("Spada", 40, 80, 5);
        public ArmaCorpoACorpo ascia = new ArmaCorpoACorpo("Ascia", 30, 100, 4);
        public ArmaCorpoACorpo pugnale = new ArmaCorpoACorpo("Pugnale", 20, 60, 3);
        public Arma glock17 = new Arma ("Glock17", 100, 120 );
        public Arma minigun = new Arma("Minigun", 700, 5000);
        public Arma shotgun = new Arma("Shotgun", 250, 50);
        public Armatura magliaDiFerro = new Armatura("Maglia di Ferro", 40);
        public Armatura armaturaDiFerro = new Armatura("Armatura di Ferro", 100);
    }
}
