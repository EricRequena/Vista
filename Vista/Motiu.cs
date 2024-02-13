using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vista
{
    public class Motiu
    {
        private string motius;


  
        public string Motius { get { return motius; } set { motius = value; } }



        public Motiu(string motiu)
        {
            Motius = motiu;
        }

        public void GetMotiuInfo()
        {
            Console.WriteLine($"Motius = {Motius}");
        }
    }
}
