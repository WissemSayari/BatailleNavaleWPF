using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class SousMarin : Navire
    {
        // taille de SousMarin dans l'ennumu
        public static new int Taille = 1;

        // constructeur 
        // base: envoie les argument au classe parent (taille,case,charactere pour chaque type)
        public SousMarin( Case[] carres) : base(Taille, carres, 'S')
        {

        }
    }
}
