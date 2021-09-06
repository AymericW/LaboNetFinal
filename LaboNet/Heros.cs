using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Heros : Personnage
    {
        public Heros(Classe classe) 
            : base(classe)
        {
        }

        public int TotalOR { get; set; }
        public int TotalCuir { get; set; }
        
    }
}
