using System;
using OOPVisita;

namespace OOPVisita
{
    public class Pacient : Visita.
    {
        private string nom;
        private string raça;
        private int edat;
        private bool vacunat;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Raça
        {
            get { return raça; }
            set { raça = value; }
        }
        public int Edat
        {
            get { return edat; }
            set { edat = value; }
        }
        public bool Vacunat
        {
            get { return vacunat; }
            set { vacunat = value; }
        }

        public Pacient(string nom, string raça, int edat, bool vacunat, string propietari, string pacient, DateTime data, string motiu) : base(propietari, pacient, data, motiu)
        {
            Nom = nom;
            Raça = raça;
            Edat = edat;
            Vacunat = vacunat;
        }

        public override string ToString()
        {
            return $"PACIENT:   Nom: {Nom}, Raça: {Raça}, Edat: {Edat}, Vacunat: {Vacunat}, {base.ToString()}";
        }


    }
}
