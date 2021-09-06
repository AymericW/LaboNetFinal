using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Guerrier : Classe
    {
        public string NomSort { get; set; }
        public Guerrier()
        {
            Stat = new Stats(3, 2);
        }

        public int FrappeMortele(Personnage cible)
        {
            if (cible.VieActuel < 5)
            {
                int dmg = 0;
                Random rnds = new Random();
                int exec = rnds.Next(1, 6);


                dmg = exec + 2;



                cible.VieActuel = cible.VieActuel - dmg;
                return dmg;
            }
            
            int degats = 0;
            Random rnd = new Random();
            int dice = rnd.Next(2, 7);


            degats = dice + 2;



            cible.VieActuel = cible.VieActuel - degats;
            return degats;

            
        }

        public override int TechniqueSpeciale(Personnage cible)
        {
            return FrappeMortele(cible);
        }

        public override int SpiritOfTheWarriorPast(Personnage cible)
        {
            throw new NotImplementedException();
        }
    }
}
