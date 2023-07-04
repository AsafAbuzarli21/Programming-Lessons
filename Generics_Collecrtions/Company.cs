using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections
{
    public class Company
    {
        public List<string> Emplees { get; set; } = new List<string>();
        public List<double> Salaries { get; set; } = new List<double>();

        public void AddEmploee(string emploee, double salary)
        {
            Emplees.Add(emploee);
            Salaries.Add(salary);
        }

        public void ShowAllEmploeeSalaries()
        {
            for (int i = 0; i < Emplees.Count; i++)
            {
                Console.WriteLine(Emplees[i] + " " + Salaries[i]);
            }
        }

        public double GetSalary(string emploee)
        {
            int index = Emplees.IndexOf(emploee);
            return Salaries[index];
        }

        public void UpdateSalary(string emploee, double salary)
        {
            int emploeeIndex = Emplees.IndexOf(emploee);
            Salaries[emploeeIndex] = salary;
        }

        public string GetEmploeeWithSalary()
        {
            double salary = Salaries.Max();

            int salaryIndex = Salaries.IndexOf(salary);

            return Emplees[salaryIndex];
        }

        public void RemoveEmploee(string emploee)
        {
            int emploeeIndex = Emplees.IndexOf(emploee);

            Emplees.RemoveAt(emploeeIndex);

            Salaries.RemoveAt(emploeeIndex);
        }
    }

    public class Emplee
    {
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
    }
}
