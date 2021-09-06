using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Dragonnet : Monstres, IDepouilleCuir, IDepouilleOr
    {
        public override int Endurance
        {
            get
            {
                return base.Endurance + 1;
            }
        }
        public Dragonnet(Classe classe)
        {

        }
        public Dragonnet() 
          
        {
            
            

        }

        public int donnercuir()
        {
            Random rnds = new Random();
            int Cuir = rnds.Next(1, 5);
            return Cuir;
        }

        public int donneror()
        {
            Random rnd = new Random();
            int Or = rnd.Next(1, 7);
            return Or;
        }
    }
}
