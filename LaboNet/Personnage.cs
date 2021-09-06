using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace LaboNet
{
    class Personnage
    {
        public virtual int Endurance
        {
            get
            {
                return Stat.Endurance;
            }
        }
        public virtual int Force
        {
            get
            {
                return Stat.Force;
            }
        }
        // Stat de base du perso
        private Stats stat;
        // Retourne les stats de base du perso + les stats de sa classe
        private Stats Stat
        {
            get
            {
                if (Classe == null)
                {
                    return stat;
                }
                return stat + Classe.Stat;
            }
        }
        public int PV { get; }
        public int VieActuel { get; set; }
        public Classe Classe { get; set; }

        public Personnage(Classe classe)
        {
            Classe = classe;
            Random rnd = new Random();
            int endurance = 0;
            int x = 10;
            for (int i = 0; i < 5; i++)
            {
                int dice = rnd.Next(1, 7);
                endurance += dice;
                if (dice < x)
                {
                    x = dice;
                }

            }
            endurance -= x;



            Random rnd2 = new Random();
            int force = 0;
            int x2 = 10;
            for (int i = 0; i < 5; i++)
            {
                int dice = rnd.Next(1, 7);
                force += dice;
                if (dice < x2)
                {
                    x2 = dice;
                }

            }
            force -= x2;

            stat = new Stats(endurance, force);

            if (Endurance < 5)
            {
                PV = Endurance - 1;
            }
            else if (Endurance < 10)
            {
                PV = Endurance;
            }
            else if (Endurance < 15)
            {
                PV = Endurance + 1;
            }
            else
            {
                PV = Endurance + 2;
            }
            VieActuel += PV;
        }

        public int buff(Personnage cible)
        {
            Stat.Endurance = cible.Classe.SpiritOfTheWarriorPast(cible);
            return Stat.Endurance;
        }

        public int frappe(Personnage cible)
        {
            int degats = 0;
            Random rnd = new Random();
            int dice = rnd.Next(1, 5);

            if (Force < 5)
            {
                degats = dice - 1;
            }
            else if (Force < 10)
            {
                degats = dice;
            }
            else if (Force < 15)
            {
                degats = dice + 1;
            }
            else
            {
                degats = dice + 2;
            }


            cible.VieActuel = cible.VieActuel - degats;
            return degats;
        }

        public void combat(Heros cible, Personnage cible2)
        {
            int cptheal = 0;
            bool fui = false;
            do
            {

                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("Tapez 1 Pour Auto attack");
                Console.WriteLine("Tapez 2 Pour utilisez votre sort.");
                Console.WriteLine("Tapez 3 pour essayer de fuir!");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 2:
                        {
                            if (cible.Classe is Guerrier)
                            {
                                if (cible2.VieActuel < 5)
                                {
                                    int dmg = cible.Classe.TechniqueSpeciale(cible2);

                                    Console.WriteLine($"Vous avez executer le monstre pour un montant de  : {dmg} !");
                                }
                                else
                                {
                                    int damage = cible.Classe.TechniqueSpeciale(cible2);

                                    Console.WriteLine($"La Frappe mortele frappe pour un montant de : {damage}");
                                }
                            }
                            else if (cible.Classe is Paladin)
                            {
                                if (cptheal < 5)
                                {
                                    int damage = cible.Classe.TechniqueSpeciale(cible);
                                    cptheal++;
                                    Console.WriteLine($"Votre hero se soigne pour  : {damage} !");

                                }
                                else
                                {
                                    Console.WriteLine("OOM!");
                                }
                              
                                
                                
                            }





                            break;
                        }

                    case 1:
                        {
                            int dgt = cible.frappe(cible2);
                            Console.WriteLine($"Le héro frappe pour un montant de : {dgt} ! ");
                            break;
                        }
                    case 3:
                        {
                            Random rnd = new Random();
                            int dice = rnd.Next(1, 3);
                            if (dice == 2)
                            {
                                fui = true;
                                Console.WriteLine("Vous avez fui !!");
                                
                                
                            }
                            else
                            {
                                
                                Console.WriteLine("ECHEC DE LA FUITE");
                            }
                            break;
                        }
                }



                if (cible2.VieActuel > 0)
                {

                    int dgt2 = cible2.frappe(cible);
                    Console.WriteLine($"Le monstre frappe pour un montant de : {dgt2} ! ");


                }
                else
                {
                    Console.WriteLine($"{cible2.GetType().Name} est mort !");
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Final_Fantasy_Retold_-_Victory_in_Combat-409257225.wav";
                    player.Play();
                }
                Console.WriteLine("\n");
                
            } while ((cible.VieActuel > 0 && cible2.VieActuel > 0) && fui == false);
           

            if (cible.VieActuel <= 0)
            {
                Console.WriteLine($"{cible.GetType().Name} est mort ! ");

                cible.VieActuel = PV;
            }
            if (cible2.VieActuel <= 0)
            {
                if (cible2 is IDepouilleCuir && cible2 is IDepouilleOr)
                {
                    IDepouilleCuir idc = (IDepouilleCuir)cible2;
                    cible.TotalCuir = idc.donnercuir();
                    IDepouilleOr ido = (IDepouilleOr)cible2;
                    cible.TotalOR = ido.donneror();
                    Console.WriteLine($"Le heros à reçu {cible.TotalOR} or et {cible.TotalCuir} Cuir !");
                }
                else if (cible2 is IDepouilleCuir)
                {
                    IDepouilleCuir idc = (IDepouilleCuir)cible2;
                    cible.TotalCuir = idc.donnercuir();
                    Console.WriteLine($"Le heros à reçu {cible.TotalCuir} Cuir !");
                }
                else
                {
                    IDepouilleOr ido = (IDepouilleOr)cible2;
                    cible.TotalOR = ido.donneror();
                    Console.WriteLine($"Le heros à reçu {cible.TotalOR} or!");
                }
                cible2.VieActuel = PV;
            }




        }



    }
}
