using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Humain : Heros
    {
        public Humain(Classe classe) 
            : base(classe)
        {
        }

        public override int Endurance
        {
            get
            {
                return base.Endurance + 1;
            }
        }
        public override int Force
        {
            get
            {
                return base.Force + 1;
            }
        }
       


      
    }
}
