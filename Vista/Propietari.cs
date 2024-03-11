using System;
namespace OOPVisita
{
    public class Propietari : Visita
    {
        private string dni;
        private string nom;
        private string cognoms;
        private int telefon;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Cognoms
        {
            get { return cognoms; }
            set { cognoms = value; }
        }
        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        public Propietari(string dni, string nom, string cognoms, int telefon, string propietari, string pacient, DateTime data, string motiu) : base(propietari, pacient, data, motiu)
        {
            Dni = dni;
            Nom = nom;
            Cognoms = cognoms;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $" PROPIETARI:   DNI: {Dni}, Nom: {Nom}, Cognoms: {Cognoms}, Telefon: {Telefon}, {base.ToString()}";
        }
    }
}