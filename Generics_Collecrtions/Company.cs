namespace Generics_Collections
{
    public class Company2
    {
        //public List<Employee> Employees { get; set; }

        public List<string> Employees { get; set; } = new List<string>();
        public List<double> Salaries { get; set; } = new List<double>();

        public void AddEmployee(string employee, double salary)
        {
            Employees.Add(employee);
            Salaries.Add(salary);
        }

        public void ShowAllEmployeeSalaries()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine(Employees[i] + " " + Salaries[i]);
            }
        }

        public double GetSalary(string employee)
        {
            int index = Employees.IndexOf(employee);
            return Salaries[index];
        }

        public void UpdateSalary(string employee, double salary)
        {
            int emploeeIndex = Employees.IndexOf(employee);
            Salaries[emploeeIndex] = salary;
        }

        public string GetEmployeeWithSalary()
        {
            double salary = Salaries.Max();

            int salaryIndex = Salaries.IndexOf(salary);

            return Employees[salaryIndex];
        }

        public void RemoveEmployee(string employee)
        {
            int emploeeIndex = Employees.IndexOf(employee);

            Employees.RemoveAt(emploeeIndex);

            Salaries.RemoveAt(emploeeIndex);
        }
    }

    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
    }
}
