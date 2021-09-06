using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Nain : Heros
    {
        public Nain(Classe classe) 
            : base(classe)
        {
        }

        public override int Endurance
        {
            get
            {
                return base.Endurance + 2;
            }
        }
        
            
        
    }
}
