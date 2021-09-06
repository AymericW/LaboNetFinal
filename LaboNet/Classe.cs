using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    abstract class Classe
    {
        public string Nom { get; set; }
        public Stats Stat { get; set; }
        public Classe()
        {
        }

        public abstract int TechniqueSpeciale(Personnage cible);
        public abstract int SpiritOfTheWarriorPast(Personnage cible);
    }
}
