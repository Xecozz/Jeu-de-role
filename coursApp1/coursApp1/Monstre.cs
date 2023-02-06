using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursApp1
{
    public  class Monstre : Entite
    {
        public Monstre(string nom): base(nom)
        {
            int PointsDeVieMin = 50;
            int PointsDeVieMax = 70;
            this.nom = nom;
            this.pointsDeVie = random.Next(PointsDeVieMin, PointsDeVieMax);
            this.degatsMin = 5;
            this.degatsMax = 10;
        }
    }
}
