using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur : Navire
    {
        // taille de Patrouilleur dans l'enum
        public static new int Taille = 3;

        // constructeur 
        // base: envoie les argument au classe parent (taille,case,charactere pour chaque type)
        public Patrouilleur( Case[] carres) : base(3, carres,'P')
        {
        }
    }
}
