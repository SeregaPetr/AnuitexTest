using System;
using System.Collections.Generic;
using System.Linq;
using CompanyLibrary;
using CompanyLibrary.Interfaces;

namespace Anuitex
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Worker
            {
                LastName = "Кущ",
                FirstName = "Александр",
                Patronymic = "Алегович",
                Seniority = 16
            };

            Employee worker2 = new Worker
            {
                LastName = "Сыпало",
                FirstName = "Евгений",
                Patronymic = "Маркович",
                Seniority = 24
            };

            Employee worker3 = new Worker
            {
                LastName = "Филимонов",
                FirstName = "Эдуард",
                Patronymic = "Гнатович",
                Seniority = 33
            };

            Employee manager = new Manager
            {
                LastName = "Кец",
                FirstName = "Владимир",
                Patronymic = "Адольфович",
                Seniority = 35
            };

            Employee brigadier = new Brigadier
            {
                LastName = "Лымарь",
                FirstName = "Генадий",
                Patronymic = "Степанович",
                Seniority = 48
            };

            Company company = new Company();

            company = AddEmployee(company, worker1);
            company = AddEmployee(company, worker2);
            company = AddEmployee(company, manager);
            company = AddEmployee(company, brigadier);
            company = AddEmployee(company, worker3);

            Console.WriteLine("\tВсе сотрудники фирмы:");
            company.ShowEmployees();

            Console.WriteLine($"\tРабота сотрудников:");
            company.Employees.ForEach(x => Console.WriteLine(x.Work()));

            Console.WriteLine($"\tРабочих на фирме: {company.GetNumberEmployees<Worker>()}");
            List<Worker> workers = company.GetAllEmployees<Worker>();
            workers.ForEach(x => Console.WriteLine(x));

        }

        private static Company AddEmployee(Company company, Employee employee)
        {
            if (!company.IsEmployeeOfCompany(employee))
            {
                company += employee;
            }

            return company;
        }
    }

    public static class CompanyExtension
    {
        public static bool IsEmployeeOfCompany(this Company company, Employee employee)
        {
            return company.Employees.Contains<Employee>(employee);
        }

        public static void ShowEmployees(this Company company)
        {
            company.Employees.ForEach(x => Console.WriteLine(x));
        }
    }

}
