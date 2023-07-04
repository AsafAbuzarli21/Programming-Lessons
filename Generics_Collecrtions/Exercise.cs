using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections
{

    public class Company
    {
        public List<string> Employees { get; set; }
        public List<double> Salaries { get; set; }

        public Company()
        {
            Employees = new List<string>();
            Salaries = new List<double>();
        }


        public void Add(string employee, double salary)
        {
            Employees.Add(employee);
            Salaries.Add(salary);
        }

        public void ShowEmployees()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine($"Name - {Employees[i]}; + Salary - {Salaries[i]}");
            }
        }

        public double GetSalary(string employee)
        {
            int employeeIndex = Employees.IndexOf(employee);

            if (employeeIndex != -1)
            {
                return Salaries[employeeIndex];
            }
            else
            {
                return 0;
            }
        }

        public void UpdateEmployee(string employee, double newSalary)
        {
            int indexOfEmployee = Employees.IndexOf(employee);

            if (indexOfEmployee != -1)
                Salaries[indexOfEmployee] = newSalary;
            else
                Console.WriteLine("This employee is not exist!");
        }

        public string GetEmployeeNameWithMaxSalary()
        {
            double maxSalary = Salaries.Max();

            int indexOfMaxSalary = Salaries.IndexOf(maxSalary);

            return Employees[indexOfMaxSalary];
        }

        public string GetEmployeeNameWithMinSalary()
        {
            double minSalary = Salaries.Min();

            int indexOfMinSalary = Salaries.IndexOf(minSalary);

            return Employees[indexOfMinSalary];
        }

        public void RemoveEmployee(string employee)
        {
            int indexOfEmployee = Employees.IndexOf(employee);

            if (indexOfEmployee != -1)
            {
                Employees.RemoveAt(indexOfEmployee);
                Salaries.Remove(indexOfEmployee);
            }
        }

    }

    public class Exercise
    {
    }
}
