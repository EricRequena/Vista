using System;
using OOPVisita;

namespace OOPVista
{
    public class Program
    {
        public static void Main()
        {
            Visita visita = new Visita("Juan", "Firulais", new DateTime(2023, 10, 15), "Control de rutina");
            Console.WriteLine("Introduce una fecha en formato dd, mm, yyyy:");
            Console.Write("Día: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());
            DateTime fechaUsuario = new DateTime(año, mes, dia);
            visita.DiferenciaAniosMesesDias(fechaUsuario);
            Console.ReadLine();


            Console.WriteLine("Introduce una fecha en formato dd, mm, yyyy:");
            Console.Write("Día: ");

            Console.WriteLine("Introduce una fecha en formato dd, mm, yyyy:");
            Console.Write("Día: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            año = int.Parse(Console.ReadLine());
            DateTime data1 = new DateTime(año, mes, dia);


            Console.Write("Día: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            año = int.Parse(Console.ReadLine());
            DateTime data2 = new DateTime(año, mes, dia);




            if (data1 < data2)
            {
                Console.WriteLine("La primera fecha es mayor que la segunda");
            }
            else if (data1 > data2)
            {
                Console.WriteLine("La primera fecha es menor que la segunda");
            }
            else
            {
                Console.WriteLine("Las dos fechas son iguales");
            }

            Console.WriteLine(DateTime.Today.DayOfWeek);

            DateTime fechaNacimiento = new DateTime(1990, 5, 15);
            Employee empleado = new Employee("Juan", fechaNacimiento);


            int edad = empleado.CalculateAge();
            Console.WriteLine("La edad de " + empleado.Name + " es: " + edad + " años.");
        }
    }
}


