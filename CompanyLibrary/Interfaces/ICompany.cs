using System.Collections.Generic;

namespace CompanyLibrary.Interfaces
{
    public interface ICompany
    {
        List<Employee> Employees { get; set; }

        List<T> GetAllEmployees<T>() where T : Employee;
        int GetNumberEmployees<T>() where T : Employee;
    }
}