using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Config
{
    public class Boite<T> where T : Contenu
    {
        public int Longueur;
        public int Largeur;
        public int Hauteur;

        public Boite()
        {
            ConfigBoite cf = default(T).GetConfig();
            this.Longueur = cf.Longueur;
            this.Largeur = cf.Largeur;
            this.Hauteur = cf.Hauteur;
        }
    }
}
