using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Paladin : Classe
    {

        public Paladin()
        {
            Stat = new Stats(1, 4);
        }


        public int Heal(Personnage cible)
        {
            int heal = 0;
            Random rnd = new Random();
            int dice = rnd.Next(1, 5);

           
            
             heal = dice;
            


            cible.VieActuel = cible.VieActuel + heal;
            return heal;
        }

        public override int SpiritOfTheWarriorPast(Personnage cible)
        {
            int stat = 4;
            return stat;
        }


        public override int TechniqueSpeciale(Personnage cible)
        {
            return Heal(cible);
        }
    }
}
