using mikroERP.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace mikroERP.Tests.Data
{
    class Employees
    {
        public List<Employee> employees;

        public Employees()
        {
           employees = new List<Employee>
           {
           new Employee { Id = 1, FirstName = "Adam", LastName = "Kowalski", Sex = "M", Email = "adam.kowalski@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2017, 4, 23), Phone = 123456789, DateOfBirth = new DateTime(1994, 11, 1), DepartmentId = 2 , TransportId = 1 },
           new Employee { Id = 2, FirstName = "Ewa", LastName = "Lampa", Sex = "F", Email = "ewa.lampa@xx.pl", Wages = 3000, DayOfEmployment = new DateTime(2007, 6, 13), Phone = 123789456, DateOfBirth = new DateTime(1974, 5, 12), DepartmentId = 3, TransportId = 6 },
           new Employee { Id = 3, FirstName = "Kacper", LastName = "Stół", Sex = "M", Email = "kacper.stol@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2011, 11, 1), Phone = 345126789, DateOfBirth = new DateTime(1987, 3, 12), DepartmentId = 4, TransportId = 4 },
           new Employee { Id = 4, FirstName = "Joanna", LastName = "Poduszka", Sex = "F", Email = "joanna.poduszka@xx.pl", Wages = 4000, DayOfEmployment = new DateTime(2014, 8, 30), Phone = 123678945, DateOfBirth = new DateTime(1995, 6, 4), DepartmentId = 4, TransportId = 5 },
           };
        }
    }
}
