using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Destroyer : Navire
    {
        // taille de destroyer dans l'ennum
        public static new int Taille = 2;

        // constructeur 
        // base: envoie les argument au classe parent (taille,case,charactere pour chaque type)
        public Destroyer( Case[] carres ) : base ( 2, carres,'D')
        {
        }
    }
}
