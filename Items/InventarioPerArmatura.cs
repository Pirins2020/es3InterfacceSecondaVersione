using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Items
{
    public class InventarioPerArmatura
    {
        public List<Armatura> armatura = new List<Armatura>() {};
        public Armatura HeldArmor;

        public InventarioPerArmatura()
        {
            HeldArmor = null;
        }
        public void AddArmatura(Armatura armor)
        {
            if (HeldArmor == null)
            {
                armatura.Add(armor);
                HeldArmor = armor;
            }

        }

        public void RemoveArmatura(Armatura armor)
        {
            if (HeldArmor != null)
            {
                armatura.Remove(armor);
                HeldArmor = null;
            }
        }

        public void ChangeArmatura(Armatura newArmor)
        {
            if (HeldArmor != null)
            {
                armatura.Remove(HeldArmor);
                HeldArmor = newArmor;
                armatura.Add(newArmor);
            }
        }

        public void ShowArmatura()
        {
            Console.WriteLine("Armature in inventory:");
            foreach (var armor in armatura)
            {
                Console.WriteLine($"- {armor.Name} (Protection: {armor.Protection})");
            }
        }
    }
}
