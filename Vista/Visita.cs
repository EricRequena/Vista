using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Visita
    {
        private string motiu;
        private string pacient;
        private string propietari;

        public string Motiu { get { return motiu; } set { motiu = value; } }
        public string Pacient { get { return pacient; } set { pacient = value; } }
        public string Propietari { get { return propietari; } set { propietari = value; } }

        public Visita(string motiu, string pacient, string propietari)
        {
            Motiu = motiu;
            Pacient = pacient;
            Propietari = propietari;
        }

        public virtual string GetInfo()
        {
            return $"Motiu = {Motiu} | Pacient = {Pacient} | Propietari = {Propietari} |";
        }   

    }
}
