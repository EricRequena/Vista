using System;

namespace OOPVisita
{
    public class Visita
    {
        public string Propietari { get; }
        public string Pacient { get; }
        public DateTime Data { get; }
        public string Motiu { get; }

        public Visita(string propietari, string pacient, DateTime data, string motiu)
        {
            Propietari = propietari;
            Pacient = pacient;
            Data = data;
            Motiu = motiu;
        }

        public override string ToString()
        {
            return $"Propietari: {Propietari}, Pacient: {Pacient}, Data: {Data.ToString("yyyy-MM-dd HH:mm")}, Motiu: {Motiu}";
        }

        public void DiferenciaAniosMesesDias(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            // Calcula la diferencia total en años, meses y días
            int anios = fechaActual.Year - fecha.Year;
            int meses = fechaActual.Month - fecha.Month;
            int dias = fechaActual.Day - fecha.Day;

            // Corrige los resultados si los días o meses son negativos
            if (meses < 0 || (meses == 0 && dias < 0))
            {
                anios--;
                meses += 12;
                if (dias < 0)
                {
                    meses--;
                    dias += DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);
                }
            }

            Console.WriteLine($"Han pasado {anios} años, {meses} meses y {dias} días desde la fecha indicada hasta hoy.");
        }
    }
}
