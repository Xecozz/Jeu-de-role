using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursApp1
{
    public class Sorcier : Personnage
    {
        public Sorcier(string nom) : base(nom)
        {
            pointsDeVie = 80;
            degatsMin = 10;
            degatsMax = 25;
        }
    }
}
