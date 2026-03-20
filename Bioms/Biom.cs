using es3InterfacceSecondaVersione.Character;
using es3InterfacceSecondaVersione.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione.Bioms
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
                      
                        break;
                    case 2:
                        Cammin.Add(mostro.vampire);
                       
                        break;
                    case 3:
                        Cammin.Add(arsenale.pugnale);
                     
                        break;
                    case 4:
                        Cammin.Add(arsenale.spada);
                   
                        break;
                    case 5:
                        Cammin.Add(arsenale.glock17);
                       
                        break;
                    case 6:
                        Cammin.Add(arsenale.shotgun);
                       

                        break;
                    case 7:
                        
                        
                        break;
                    case 8:
                     
                        break;
                    case 9:
                       
                        break;
                    case 10:
                      
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
