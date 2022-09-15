namespace BatailleNavale
{
    // classe grille exercice 2.4 en develeppenet informatique
    class Case
    {
        public Position Position { get; set;  }

        public bool Touche { get; private set; }

        public Navire Navire { get; set; }

        public Case(int ligne, int colonne)
        {
            Position = new Position(ligne, colonne);
            Touche = false;
        }

        public void Toucher()
        {
            Touche = true;
        }
    }
}
