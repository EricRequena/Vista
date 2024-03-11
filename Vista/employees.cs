using System;

namespace OOPVisita
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;


            if (DateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;
        }


        public override string ToString()
        {
            return $"Nom: {Name}, Edad: {CalculateAge()}";
        }

    }

}
