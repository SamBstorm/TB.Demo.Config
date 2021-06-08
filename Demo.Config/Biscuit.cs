using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Config
{
    public class Biscuit : Contenu
    {
        public override ConfigBoite GetConfig()
        {
            return new ConfigBoite { Longueur = 1, Largeur = 1, Hauteur = 1 };
        }
    }
}
