using es3InterfacceSecondaVersione.Abstraction;
using es3InterfacceSecondaVersione.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Character
{
    public class Goblin : Character, ITakeDamage, IDecreaseStrenght
    {
        public Arsenale arsenale = new Arsenale();
        public object HeldItem { get; set; }
        
        public Goblin(string name) : base(name)
        {
            InitialStrenght = 5;
            MaxLife = 200;
            Damage = 20;
            HeldItem = null;

        }

        public void TakeDamage(int damage)
        {
            MaxLife -= damage;
            Console.WriteLine($"{Name} takes {damage} damage.");
        }


        public void DecreaseStrenght()
        {
            InitialStrenght -= 2;
            Console.WriteLine($"{Name} loses {2} strenght.");
        }

        public void TakeItem(object item)
        {
            HeldItem = item;
            HoldMeleeWeapon();
        }

        public void HoldMeleeWeapon()
        {
            if (HeldItem is ArmaCorpoACorpo)
            {
                Damage = ((ArmaCorpoACorpo)HeldItem).Damage;
            }
        }
        public void assignRandomWeapon()
        {
            switch (new Random().Next(1, 5))
            {
                case 1:
                    TakeItem(arsenale.pugnale);
                   
                    break;
                case 2:
                    TakeItem(arsenale.ascia);
                    break;
                case 3:
                    TakeItem(arsenale.spada);
                    break;
                case 4:
                    break;
            }
        }
    }
}
