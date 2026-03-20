using es3InterfacceSecondaVersione.Bioms;
using es3InterfacceSecondaVersione.Character;
using es3InterfacceSecondaVersione.Items;


namespace es3InterfacceSecondaVersione
{
    public class Program
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
            Console.WriteLine("Duke         press [1]");
            Console.WriteLine("Knite        press [2]");
            Console.WriteLine("Feudatary    press [3]");
            Console.WriteLine("Guard        press [4]");
            Console.WriteLine("Servant      press [5]");



            string choice = Console.ReadLine();
            int choiceInt = int.Parse(choice);
            if(choiceInt == 1)
            {
                hero.duke.AddObjectRandomly();
                hero.duke.PrintInventory();
                hero.duke.UseItem();
                hero.duke.PrintStatus();

                attack.AttackInBiom(place.castello, hero.duke );
            }
            if (choiceInt == 2)
            {

            }
            if (choiceInt == 3)
            {

            }
            if (choiceInt == 4)
            {

            }
            if (choiceInt == 5)
            {

            }
        }
    }
}
    