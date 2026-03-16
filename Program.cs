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
            Place place = new Place();


            Console.WriteLine("Scegli il tuo eroe:");
            Console.WriteLine("1. Duke");
            Console.WriteLine("2. Knite");



            string choice = Console.ReadLine();
            if (choice == "Duke" || choice == "duke")
            {
                hero.duke.PickUpItem(arsenale.ascia);
                hero.duke.PickUpItem(arsenale.glock17);

                hero.duke.PickUpItem(arsenale.spada);
                hero.duke.PickUpItem(arsenale.pugnale);
                hero.duke.PrintInventory();
                hero.duke.PrintStatus();
                Console.WriteLine("Scegli l'arma da usare:");


                hero.duke.UseItem();

                place.foresta.AddObject();
                place.foresta.PrintInfoBiom();
                


            }
        }
    }
}
    