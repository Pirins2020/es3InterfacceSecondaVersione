using es3InterfacceSecondaVersione.Character;
using es3InterfacceSecondaVersione.Items;
using System.Security.Cryptography.X509Certificates;

namespace es3InterfacceSecondaVersione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Istanze :
            Attack attack = new Attack();
            Hero hero = new Hero();
            Mostro mostro = new Mostro();
            Arsenale arsenale = new Arsenale();

            Console.WriteLine("Scegli il tuo eroe:");
            Console.WriteLine("1. Duke");
            Console.WriteLine("2. Knite");

           

            string choice = Console.ReadLine();
            if (choice == "Duke" || choice == "duke")
            {
                hero.duke.PickUpItem(arsenale.ascia);
                hero.duke.PickUpItem(arsenale.glock17);
                hero.duke.WearArmor(arsenale.magliaDiFerro);
                hero.duke.ShowArmatura();
                hero.duke.PrintInventory();
                hero.duke.PrintStatus();
                Console.WriteLine("Scegli l'arma da usare:");
                string weaponChoice = Console.ReadLine();
                if (weaponChoice == "1")
                {
                    hero.duke.UseItem(1);
                }
                else if (weaponChoice == "2")
                {
                    hero.duke.UseItem(2);
                }
                attack.AttackVampire(hero.duke, mostro.vampire);
            }
            else if (choice == "Knite" || choice == "knite")
            {
                attack.AttackGoblin(hero.knite, mostro.goblin);

            }
        }
    }
}