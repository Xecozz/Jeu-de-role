using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursApp1
{
    public class Guerrier : Personnage
    {
        public Guerrier(string nom) : base(nom)
        {
            pointsDeVie = 120;
            degatsMin = 10;
            degatsMax = 15;
        }
    }
}
