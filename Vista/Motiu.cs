using System;

namespace OOPVisita
{
    public class Motiu : Visita
    {
        private string motiuUrgencia;
        public string MotiuUrgencia
        {
            get { return motiuUrgencia; }
            set { motiuUrgencia = value; }
        }

        public Motiu(string motiuUrgencia, string propietari, string pacient, DateTime data, string motiu) : base(propietari, pacient, data, motiu)
        {
            MotiuUrgencia = motiuUrgencia;
        }
        public override string ToString()
        {
            return $"Motiu d'urgencia: {MotiuUrgencia}, {base.ToString()}";
        }
    }
}