using es3InterfacceSecondaVersione.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Items
{
    public class ArmaCorpoACorpo : IDecreaseDurability
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int DecreaseDurab { get; set; }
        public ArmaCorpoACorpo(string name, int damage, int durability, int decreaseDurability)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            DecreaseDurab = decreaseDurability;
        }

        public void DecreaseDurability()
        {
            Durability -= DecreaseDurab;
            Console.WriteLine($"{Name} loses {DecreaseDurability} durability.");
        }



    }
}
