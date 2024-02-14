﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Propietari
    {
        private string nom;
        private string raça;
        private int edat;
        private bool vacunat;

        public string Nom { get { return nom; } set { nom = value; } }
        public string Raça { get { return raça; } set { raça = value; } }
        public int Edat { get { return edat; } set { edat = value; } }
        public bool Vacunat { get { return vacunat; } set { vacunat = value; } }

        public Propietari(string nom, string raça, int edat, bool vacunat)
        {
            Nom = nom;
            Raça = raça;
            Edat = edat;
            Vacunat = vacunat;
        }

        public void GetPropietariInfo()
        {
            Console.WriteLine($"Nom: {Nom}, Raça = {Raça}, Edat = {Edat}, Vacunat = {Vacunat}");
        }
    }
}
