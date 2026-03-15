using es3InterfacceSecondaVersione.Abstraction;
using es3InterfacceSecondaVersione.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Character
{
    public class Vampire : Character, ITakeDamage, IDecreaseStrenght
    {
        public Arsenale arsenale = new Arsenale();
        public object HeldItem { get; set; }
        public Vampire(string name) : base(name)
        {
            InitialStrenght = 8;
            MaxLife = 150;
            Damage = 15;
        }
        
        public void TakeDamage(int damage)
        {
            MaxLife -= damage;
            Console.WriteLine($"{Name} takes {damage} damage.");
        }

        public void DecreaseStrenght()
        {
            InitialStrenght -= 1;
            Console.WriteLine($"{Name} loses {1} strenght.");
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
