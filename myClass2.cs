namespace GitExercise
{
    class myClass
    {
        private string navn;

        private string adresse;

        private int postnummer;

        private string by;

        public myClass(string navn, string adresse, int postnummer, string by)
        {
            this.Navn = navn;
            this.Adresse = adresse;
            this.Postnummer = postnummer;
            this.By = by;
        }

        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Postnummer { get => postnummer; set => postnummer = value; }
        public string By { get => by; set => by = value; }
        public override string ToString()
        {
            return $"{navn} bor på {adresse}, {postnummer}{by}";
        }
    }
}