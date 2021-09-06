using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class Stats
    {
        public int Endurance { get; set; }
        public int Force { get; set; }
        public Stats(int endurance, int force)
        {
            Endurance = endurance;
            Force = force;

           
        }

        public static Stats operator +(Stats s1, Stats s2) {
            return new Stats(s1.Endurance + s2.Endurance, s1.Force + s2.Force);
        }
    }
}      

