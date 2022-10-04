using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvions : Navire
    {
        // taille de PorteAvions dans l'ennumuration
        public static new int Taille = 5;

        // constructeur 
        // base: envoie les argument au classe parent (taille,case,charactere pour chaque type)
        public PorteAvions( Case[] carres) : base(5, carres,'A')
        {
        }
    }
}
