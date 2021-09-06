using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Loup : Monstres, IDepouilleCuir
    {

        public Loup(Classe classe)
        {

        }
        public Loup()
        {
           
            
            
        }

        public int donnercuir()
        {
            Random rnds = new Random();
            int Cuir = rnds.Next(1, 5);
            return Cuir;
        }
    }
}
