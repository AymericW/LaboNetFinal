using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNet
{
    class dice
    {
        public int Maximum { get; set; }
        public int Minimum { get; set; }


        public int Lance()
        {
            Random rnd = new Random();
            int lance = rnd.Next();
            return lance;
        }
    }
}
