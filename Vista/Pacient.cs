using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vista
{
    public class Pacient
    {
        private int dni;
        private string nom_cognoms;
        private int telefon;

        public int DNI { get { return dni; } set { dni = value; } } 

        public string Nom_cognom {  get { return nom_cognoms; } set { nom_cognoms = value; } }

        public int Telefon { get { return telefon; } set { telefon = value; } }

        public Pacient(int dni, string nom_cognoms, int telefon)
        {
            DNI = dni;
            Nom_cognom = nom_cognoms;
            Telefon = telefon;
        }

        public void GetPacientInfo()
        {
            Console.WriteLine($"DNI: {DNI}, Nom_cognom = {Nom_cognom}, Telefon = {Telefon}");
        }
    }
}
