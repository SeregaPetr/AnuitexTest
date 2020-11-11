using System.Collections.Generic;
using System.Linq;
using CompanyLibrary.Interfaces;

namespace CompanyLibrary
{
    public class Company : ICompany
    {
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public static Company operator +(Company company, Employee employee)
        {
            company.Employees.Add(employee);
            return company;
        }

        public static Company operator -(Company company, Employee employee)
        {
            company.Employees.Remove(employee);
            return company;
        }

        public List<T> GetAllEmployees<T>() where T : Employee
        {
            return Employees.OfType<T>().ToList();
        }

        public int GetNumberEmployees<T>() where T : Employee
        {
            return Employees.Count(x => x.GetType() == typeof(T));
        }
    }
}
