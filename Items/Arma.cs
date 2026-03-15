using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Items
{
    public class Arma 
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int MunitionNumber { get; set; }

        public Arma(string name, int damage, int munitionNumber)
         {
            Name = name;
            Damage = damage;
            MunitionNumber = munitionNumber;
        }

        public void Shoot()
        {
            if (MunitionNumber > 0)
            {
                MunitionNumber--;
                Console.WriteLine($"{Name} shoots and deals {Damage} damage. Remaining munition: {MunitionNumber}");
            }
            else
            {
                Console.WriteLine($"{Name} has no munition left!");
            }
        }
    }
}
