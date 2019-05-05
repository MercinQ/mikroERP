using mikroERP.API.Models;
using mikroERP.Tests.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mikroERP.Tests
{
    class EmployeeTests
    {
        private readonly Employees _employees = new Employees();
        private readonly List<Employee> _employeeList;

        public EmployeeTests()
        {
            _employeeList = _employees.employees;
        }

        [Test]
        public void GetEmployee_ReturnsEmployeeByID_Returned()
        {
            var employeeExcepted = new Employee
            {
                Id = 1,
                FirstName = "Adam",
                LastName = "Kowalski",
                Sex = "M",
                Email = "adam.kowalski@xx.pl",
                Wages = 5000,
                DayOfEmployment = new DateTime(2017, 4, 23),
                Phone = 123456789,
                DateOfBirth = new DateTime(1994, 11, 1),
                DepartmentId = 2,
                TransportId = 1
            };

            List<Employee> employeeListCopy = _employeeList;

            Employee employeeActual = employeeListCopy.FirstOrDefault(u => u.Id == 1);

            Assert.AreEqual(employeeExcepted.Id, employeeActual.Id);
            Assert.AreEqual(employeeExcepted.FirstName, employeeActual.FirstName);
            Assert.AreEqual(employeeExcepted.LastName, employeeActual.LastName);
            Assert.AreEqual(employeeExcepted.Sex, employeeActual.Sex);
            Assert.AreEqual(employeeExcepted.Email, employeeActual.Email);
            Assert.AreEqual(employeeExcepted.Wages, employeeActual.Wages);
            Assert.AreEqual(employeeExcepted.DayOfEmployment, employeeActual.DayOfEmployment);
            Assert.AreEqual(employeeExcepted.Phone, employeeActual.Phone);
            Assert.AreEqual(employeeExcepted.DateOfBirth, employeeActual.DateOfBirth);
            Assert.AreEqual(employeeExcepted.DepartmentId, employeeActual.DepartmentId);
            Assert.AreEqual(employeeExcepted.TransportId, employeeActual.TransportId);
        }

        [Test]
        public void DeleteEmployee_DeleteEmployeeFromDB_Deleted()
        {
            List<Employee> employeeListExcepted = _employeeList;

            List<Employee> employeeListActual = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Adam", LastName = "Kowalski", Sex = "M", Email = "adam.kowalski@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2017, 4, 23), Phone = 123456789, DateOfBirth = new DateTime(1994, 11, 1), DepartmentId = 2 , TransportId = 1 },
                new Employee { Id = 2, FirstName = "Ewa", LastName = "Lampa", Sex = "F", Email = "ewa.lampa@xx.pl", Wages = 3000, DayOfEmployment = new DateTime(2007, 6, 13), Phone = 123789456, DateOfBirth = new DateTime(1974, 5, 12), DepartmentId = 3, TransportId = 6 },
                new Employee { Id = 3, FirstName = "Kacper", LastName = "Stół", Sex = "M", Email = "kacper.stol@xx.pl", Wages = 5000, DayOfEmployment = new DateTime(2011, 11, 1), Phone = 345126789, DateOfBirth = new DateTime(1987, 3, 12), DepartmentId = 4, TransportId = 4 }
            };

            var employeeToDelete = employeeListExcepted.Find(e => e.Id == 4);

            employeeListExcepted.Remove(employeeToDelete);

            Assert.AreEqual(employeeListExcepted.Count(), employeeListActual.Count());
        }

    }
}
