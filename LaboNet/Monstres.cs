using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Monstres : Personnage
    {
        public Monstres()
            : base(null) 
        {

        }

        public Monstres(Classe classe)
            : base(classe)
        {

        }
    }
}
