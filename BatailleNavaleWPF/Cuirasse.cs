using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Cuirasse : Navire
    {
        // taille de Cuirasse dans l'ennum
        public static new int Taille = 4;

        // constructeur 
        // base: envoie les argument au classe parent (taille,case,charactere pour chaque type)
        public Cuirasse(Case[] carres) : base(4, carres,'C')
        {

        }
    }
}
