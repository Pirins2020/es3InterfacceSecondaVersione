using es3InterfacceSecondaVersione.Character;
using es3InterfacceSecondaVersione.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione
{
    public class Biom
    {
        public Arsenale arsenale = new Arsenale();
        public Mostro mostro = new Mostro();
        public string Name { get; set; }
        public string Description { get; set; }
        public List<object> Cammin = new List<object>() { 10};
       

        public Biom(string name, string description)
        {
            Name = name;
            Description = description;
            
        }

        public void AddObject()
        {
            for (int i = 0; i < 10; i++)
            {


                switch (new Random().Next(1, 11))
                {
                    case 1:
                        Cammin.Add(mostro.goblin);
                        Console.WriteLine($"Added {mostro.goblin.Name} to the biom.");
                        break;
                    case 2:
                        Cammin.Add(mostro.vampire);
                        Console.WriteLine($"Added {mostro.vampire.Name} to the biom.");
                        break;
                    case 3:
                        Cammin.Add(arsenale.pugnale);
                        Console.WriteLine($"Added {arsenale.pugnale.Name} to the biom.");
                        break;
                    case 4:
                        Cammin.Add(arsenale.spada);
                        Console.WriteLine($"Added {arsenale.spada.Name} to the biom.");
                        break;
                    case 5:
                        Cammin.Add(arsenale.glock17);
                        Console.WriteLine($"Added {arsenale.glock17.Name} to the biom.");
                        break;
                    case 6:
                        Cammin.Add(arsenale.shotgun);
                        Console.WriteLine($"Added {arsenale.shotgun.Name} to the biom.");

                        break;
                    case 7:
                        Console.WriteLine("nothing1");
                        
                        break;
                    case 8:
                        Console.WriteLine("nothing2");
                        break;
                    case 9:
                        Console.WriteLine("nothing3");
                        break;
                    case 10:
                        Console.WriteLine("nothing4");
                        break;
                }
            }
        }

        public void PrintInfoBiom()
        {
            foreach (var item in Cammin)
            {
                if (item is Goblin)
                { 
                    Console.WriteLine (((Goblin)item).Name);
                }
                if (item is Vampire)
                { 
                    Console.WriteLine(((Vampire)item).Name);
                }
                if (item is Uman)
                { 
                    Console.WriteLine(((Uman)item).Name);
                }
                if(item is ArmaCorpoACorpo)
                {
                    Console.WriteLine(((ArmaCorpoACorpo)item).Name);
                }
                if(item is Arma)
                {
                    Console.WriteLine(((Arma)item).Name);
                }
            }
        }
    }


        
        
}
