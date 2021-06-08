using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Config
{
    public class Jouet : Contenu
    {
        public string Marque;
        public bool isElectrick;
        public override ConfigBoite GetConfig()
        {
            return new ConfigBoite { Longueur = 3, Largeur = 3, Hauteur = 3 };
        }
    }
}
