using System;
using Vista;
namespace MySpace
{
    public class  MyClass
    {
        public static void Main()
        {
            Pacient MolAno = new Pacient(12345678, "Mol Ano", 666666666, "motivo", "MolAno", "Eric");
        
            Visita visitas = new Visita("motivo", "MolAno", "Eric");
      
            Propietari Yo = new Propietari("Eric", "Persona", 18, true, "motivo", "MolAno", "Eric");


            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(MolAno.GetInfo());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(visitas.GetInfo());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(Yo.GetInfo());
            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
