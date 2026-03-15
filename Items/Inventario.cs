using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Items
{
    public class Inventario
    {
        public List<object> items = new List<object>() { 10 };
        public object HeldItem { get; set; }
        public ArmaCorpoACorpo MeleeWeapon;
        public Arma Weapon;
        public Inventario()
        {
            HeldItem = null;
        }
        public void AddItem(object item)
        {
            items.Add(item);
            Console.WriteLine($"Added {item} to inventory.");
        }
        public void RemoveItem(object item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"Removed {item} from inventory.");
            }
            else
            {
                Console.WriteLine($"{item} not found in inventory.");
            }
        }

        public void ChangeItem(object oldItem, object newItem)
        {
            if (items.Contains(oldItem))
            {
                int index = items.IndexOf(oldItem);
                items[index] = newItem;
                Console.WriteLine($"Changed {oldItem} to {newItem} in inventory.");
            }
            else
            {
                Console.WriteLine($"{oldItem} not found in inventory.");
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Inventory:");
            int position = 0;
            foreach (var item in items)
            {

                if (item != null)
                {
                    if (item is ArmaCorpoACorpo)
                    {
                        MeleeWeapon = (ArmaCorpoACorpo)item;
                        Console.WriteLine($"- {MeleeWeapon.Name} position = {position}  ");

                    }

                    else if (item is Arma)
                    {
                        Weapon = (Arma)item;
                        Console.WriteLine($"- {Weapon.Name} position = {position}  ");
                    }
                }
                else
                {
                    Console.WriteLine("- Empty slot");
                }
                position++;
            }
        }
    

        

        public void HoldItem(int position)
            {
            if (position >= 0 && position < items.Count)
            {
                Console.WriteLine($"Holding {items[position]} from inventory.");
                HeldItem = items[position];
            }
            else
            {
                Console.WriteLine("Invalid inventory position.");
            }
        }

    }
}
