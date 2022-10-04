using System;

namespace BatailleNavale
{
    // Un Navire est l'implémentation d'un INavire
    class Navire : INavire
    {
        public int Taille { get; }
        public bool Coule { get => EstCoule(); }

        // lire le charactere de chaque type
        public char Lettre;

        private readonly Case[] cases;

        // Constructeur pour la position de navire
        public Navire(int taille, Case[] carres, char lettre)
        {
            Taille = taille;
            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
            Lettre = lettre;
        }

        private bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
