using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Config
{
    public class DeNuit : Contenu
    {
        public override ConfigBoite GetConfig()
        {
            return new ConfigBoite { Longueur = 5, Largeur = 5, Hauteur = 5 };
        }
    }
}
