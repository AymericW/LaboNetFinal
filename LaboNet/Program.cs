using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace LaboNet
{
    class Program
    {
        static void Main(string[] args)

        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Final_Fantasy_Theme-200802565.wav";
            player.Play();
            Console.WriteLine("------BIENVENUE DANS LA FORET DE SHERWOOD------------");
            Classe c = new Guerrier();
            Nain n1 = new Nain(c);
            Console.WriteLine("------------------NAIN------------");
            Console.WriteLine("Endurance : " + n1.Endurance);
            Console.WriteLine("Force : " + n1.Force);
            Console.WriteLine("PV : " + n1.PV);

            Console.WriteLine("------------------ORC------------");
            Orc o1 = new Orc();
            Console.WriteLine("PV : " + o1.PV);
            Console.WriteLine("Endurance : " + o1.Endurance);
            Console.WriteLine("Force : " + o1.Force);

            Console.WriteLine("-------------COMBAT--------------");

            n1.combat(n1, o1);
            Console.WriteLine("---------------COMBAT 2-----------");
            Classe p = new Paladin();
            Humain h1 = new Humain(p);
            h1.combat(h1, o1);
            Console.WriteLine("-------------------------------------------------");





        }
    }
}
