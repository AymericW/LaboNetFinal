using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Orc : Monstres, IDepouilleOr
    {
        public override int Force
        {
            get
            {
                return base.Force + 1;
            }
        }
        public Orc(Classe classe)
        {

        }
        public Orc() 
            
        {
           
        }

        public int donneror()
        {
            Random rnds = new Random();
            int Or = rnds.Next(1, 7);
            return Or;
        }
    }
}
