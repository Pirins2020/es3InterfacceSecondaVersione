using es3InterfacceSecondaVersione.Abstraction;
using es3InterfacceSecondaVersione.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Character
{
    public class Uman : Character, ITakeDamage, IDecreaseStrenght
    {
        public Inventario inventario = new Inventario();
        public InventarioPerArmatura inventarioPerArmatura = new InventarioPerArmatura();
        public bool HasLighter {  get; set; }
        public bool HasWoodenPole { get; set; } 
        public ArmaCorpoACorpo HeldMelee { get; set; }
        public Arma HeldAWeapon { get; set; }

        public Uman(string name, bool hasLighter, bool hasWoodenPole) : base(name)
        {
            InitialStrenght = 10;
            MaxLife = 100;
            Damage = 20;
            HasLighter = hasLighter;
            HasWoodenPole = hasWoodenPole;
        }

        public void TakeDamage(int damage)
        {
            MaxLife -= damage;
            Console.WriteLine($"{Name} takes {damage} damage.");
        }

        public void DecreaseStrenght()
        {
            InitialStrenght -= 3;
            Console.WriteLine($"{Name} loses {3} strenght.");
        }

        public void PickUpItem(object item)
        {
            inventario.AddItem(item);
            
        }

        public void DropItem(object item)
        {
            inventario.RemoveItem(item);
            
        }

        public void UseItem(int position)
        {   inventario.HoldItem(position); 
            HeldMeleeWeapon();
            HeldWeapon();
        }
        public void HeldMeleeWeapon()
        {
            if (inventario.HeldItem is ArmaCorpoACorpo)
            { 
                Damage = ((ArmaCorpoACorpo)inventario.HeldItem).Damage;
                HeldMelee = (ArmaCorpoACorpo)inventario.HeldItem;
                HeldAWeapon = null;
            }
        }

        public void HeldWeapon()
        {
            if (inventario.HeldItem is Arma)
            {
                Damage = ((Arma)inventario.HeldItem).Damage;
                HeldAWeapon = (Arma)inventario.HeldItem;
                HeldMelee = null;
            }
        }

        public void PrintInventory()
        {
            inventario.DisplayInventory();
        }

        public void WearArmor(Armatura armor)
        {
            inventarioPerArmatura.AddArmatura(armor);
            MaxLife += armor.Protection;
        }

        public void RemoveArmor(Armatura armor)
        {
            inventarioPerArmatura.RemoveArmatura(armor);
            MaxLife -= armor.Protection;
        }

        public void ShowArmatura()
        {
            inventarioPerArmatura.ShowArmatura();
        }

        public void ChangeArmor(Armatura newArmor)
        {
            if (inventarioPerArmatura.HeldArmor != null)
            {
                MaxLife -= inventarioPerArmatura.HeldArmor.Protection;
            }
            inventarioPerArmatura.ChangeArmatura(newArmor);
            MaxLife += newArmor.Protection;
        }



        public void PrintStatus()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Max Life: {MaxLife}");
            Console.WriteLine($"Initial Strenght: {InitialStrenght}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Has Lighter: {HasLighter}");
            Console.WriteLine($"Has Wooden Pole: {HasWoodenPole}");
        }


    }
}
