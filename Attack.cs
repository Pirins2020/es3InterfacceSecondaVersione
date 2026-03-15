using es3InterfacceSecondaVersione.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace es3InterfacceSecondaVersione
{
    public class Attack
    {
        public Hero hero = new Hero();
        public Mostro mostro = new Mostro();
        public void AttackGoblin(Uman uman, Goblin goblin)
        {
            while (goblin.MaxLife > 0 && uman.MaxLife > 0)
            {
                var umanAttackChance = new Random().Next(1, 6);
                if (umanAttackChance == 2)
                {


                    Console.WriteLine($"{uman.Name} attacks {goblin.Name} for {uman.Damage} damage.");
                    goblin.TakeDamage(uman.Damage);
                    if (uman.HeldMelee != null)
                    {
                        uman.HeldMelee.DecreaseDurability();
                    }
                    if (uman.HeldAWeapon != null)
                    {
                        uman.HeldAWeapon.Shoot();
                    }


                }
                else
                {
                    Console.WriteLine($"{uman.Name} misses the attack on {goblin.Name}.");
                }
                if (goblin.MaxLife <= 0)
                {
                    uman.DecreaseStrenght();
                    Console.WriteLine($"{uman.Name} wins the battle!");
                    Console.WriteLine($"{uman.Name} decreased strenght of {3}");
                    Console.WriteLine($"{goblin.Name} is defeated!");
                    break;
                }
                var goblinAttackChance = new Random().Next(1, 6);
                if (goblinAttackChance == 2)
                {
                    Console.WriteLine($"{goblin.Name} attacks {uman.Name} for {goblin.Damage} damage.");
                    uman.TakeDamage(goblin.Damage);

                }
                else
                {
                    Console.WriteLine($"{goblin.Name} misses the attack on {uman.Name}.");
                }
                if (uman.MaxLife <= 0)
                {
                    goblin.DecreaseStrenght();
                    Console.WriteLine($"{goblin.Name} wins the battle!");
                    Console.WriteLine($"{goblin.Name} decreased strenght of {2}");
                    Console.WriteLine($"{uman.Name} is defeated!");
                    break;
                }
            }
        }


        public void AttackVampire(Uman uman, Vampire vampire)
        {
            while (vampire.MaxLife > 0 && uman.MaxLife > 0)
            {
                var umanAttackChance = new Random().Next(1, 6);
                if (umanAttackChance == 2)
                {


                    Console.WriteLine($"{uman.Name} attacks {vampire.Name} for {uman.Damage} damage.");
                    vampire.TakeDamage(uman.Damage);
                    if (uman.HeldMelee != null)
                    {
                        uman.HeldMelee.DecreaseDurability();
                    }
                    if (uman.HeldAWeapon != null)
                    {
                        uman.HeldAWeapon.Shoot();
                    }


                }
                else
                {
                    Console.WriteLine($"{uman.Name} misses the attack on {vampire.Name}.");
                }
                if (vampire.MaxLife <= 0 && uman.HasLighter != null || vampire.MaxLife <= 0 && uman.HasWoodenPole != null || vampire.MaxLife <= 0 && uman.HasLighter != null && uman.HasWoodenPole != null)
                {
                    uman.DecreaseStrenght();
                    Console.WriteLine($"{uman.Name} wins the battle!");
                    Console.WriteLine($"{uman.Name} decreased strenght of {3}");
                    Console.WriteLine($"{vampire.Name} is defeated!");
                    break;
                } else if (vampire.MaxLife <= 0 && uman.HasLighter == null || uman.HasWoodenPole == null)
                {
                    uman.DecreaseStrenght();
                    vampire.MaxLife = 150;
                }
                var goblinAttackChance = new Random().Next(1, 6);
                if (goblinAttackChance == 2)
                {
                    Console.WriteLine($"{vampire.Name} attacks {uman.Name} for {vampire.Damage} damage.");
                    uman.TakeDamage(vampire.Damage);

                }
                else
                {
                    Console.WriteLine($"{vampire.Name} misses the attack on {uman.Name}.");
                }
                if (uman.MaxLife <= 0)
                {
                    vampire.DecreaseStrenght();
                    Console.WriteLine($"{vampire.Name} wins the battle!");
                    Console.WriteLine($"{vampire.Name} decreased strenght of {2}");
                    Console.WriteLine($"{uman.Name} is defeated!");
                    break;
                }
            }
        }






    }
}
