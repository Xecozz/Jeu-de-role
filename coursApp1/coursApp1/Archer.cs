using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursApp1
{
    public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 108;
            degatsMin = 15;
            degatsMax = 20;
        }
    }
}
