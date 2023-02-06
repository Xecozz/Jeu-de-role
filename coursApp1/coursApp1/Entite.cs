using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursApp1
{
    public abstract class Entite
    {
        protected string nom;
        protected bool estMort = false;
        protected int pointsDeVie;
        protected int degatsMin;
        protected int degatsMax;
        protected Random random = new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite)
        {
            int degats = random.Next(degatsMin, degatsMax);

            uneEntite.PerdrePointsDeVie(degats);
            Console.WriteLine(this.nom + "("+ this.pointsDeVie+")" + " attaque : "+ uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " a perdu " + degats + " point de vie");
            Console.WriteLine("Il reste "+ uneEntite.pointsDeVie + " points de vie à " + uneEntite.nom);
            if(uneEntite.estMort)
            {
                Console.WriteLine(uneEntite.nom + " est mort!");
            }
        }

        protected void PerdrePointsDeVie(int pointDeVie)
        {
            this.pointsDeVie -= pointDeVie;
            if(this.pointsDeVie <= 0)
            {
                this.pointsDeVie = 0;
                estMort = true;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }
    }
}
