using System;
using Vista;
namespace MySpace
{
    public class  MyClass
    {
        public static void Main()
        {
            Pacient MolAno = new Pacient(12345678, "Mol Ano", 666666666);
            MolAno.GetPacientInfo();
            Motiu motiu1 = new Motiu("Dolor de cap");
            motiu1.GetMotiuInfo();
            Propietari Yo = new Propietari("Eric", "Persona", 18, true);
            Yo.GetPropietariInfo();
        }
        
    }
}
