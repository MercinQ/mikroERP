using mikroERP.API.Models;
using mikroERP.Tests.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mikroERP.Tests
{
    class ChartTests
    {
        private readonly Employees _employees = new Employees();
        private readonly List<Employee> _employeeList;

        public ChartTests()
        {
            _employeeList = _employees.employees;

        }

        private int GetDepartmentCount(int depId)
        {
            return _employeeList
            .Where(e => e.DepartmentId == depId)
            .Count();
        }

        private int GetGenderCount(string gender)
        {
            return _employeeList
            .Where(e => e.Sex == gender)
            .Count();
        }

        private double GetDepAvgEarnings(int depId, int depCount)
        {
            if (depCount == 0)
            {
                return 0;
            }
            return _employeeList
            .Where(e => e.DepartmentId == depId)
            .Sum(e => e.Wages) / depCount;
        }

        public int[] GetNumberOfEmploymentsInMonths()
        {
            int[] numberOfEmployedInMonths = new int[12];

            for (int i = 1; i <= 12; i++)
            {
                int numberInMonth = _employeeList
                .Where(e => e.DayOfEmployment.Month == i)
                .Count();
                numberOfEmployedInMonths[i - 1] = numberInMonth;
            }
            return numberOfEmployedInMonths;
        }

        [Test]
        public void GetDepartmentCount_ReturnCountOfDeparatment_Returned()
        {
            int managmentDepCountActual = GetDepartmentCount(1);
            int logisticsDepCountActual = GetDepartmentCount(2);
            int administrationDepCountActual = GetDepartmentCount(3);
            int marketingDepCountActual = GetDepartmentCount(4);

            int managmentDepCountExcepted = 0;
            int logisticsDepCountExcepted = 1;
            int administrationDepCountExcepted = 1;
            int marketingDepCountExcepted = 2;

            Assert.AreEqual(managmentDepCountExcepted, managmentDepCountActual);
            Assert.AreEqual(logisticsDepCountExcepted, logisticsDepCountActual);
            Assert.AreEqual(administrationDepCountExcepted, administrationDepCountActual);
            Assert.AreEqual(marketingDepCountExcepted, marketingDepCountActual);
        }

        [Test]
        public void GetGenderCount_ReturnCountOfGender_Returned()
        {
            int manCountActual = GetGenderCount("M");
            int womanCountActual = GetGenderCount("F"); 

            int manCountExcepted = 2;
            int womanCountExcepted = 2;

            Assert.AreEqual(manCountExcepted, manCountActual);
            Assert.AreEqual(womanCountExcepted, womanCountActual);
        }

        [Test]
        public void GetDepAvgEarnings_ReturnAverageEarnings_Returned()
        {
            double managmentAvgEarningsActual = GetDepAvgEarnings(1, GetDepartmentCount(1));

            double logisticsAvgEarningsActual = GetDepAvgEarnings(2, GetDepartmentCount(2));

            double adminiatrationAvgEarningsActual = GetDepAvgEarnings(3, GetDepartmentCount(3));

            double marketingAvgEarningsActual = GetDepAvgEarnings(4, GetDepartmentCount(4));

            double managmentAvgEarningsExcepted = 0;
            double logisticsAvgEarningsExcepted = 5000.0;
            double adminiatrationAvgEarningsExcepted = 3000.0;
            double marketingAvgEarningsExcepted = 4500.0;

            Assert.AreEqual(managmentAvgEarningsExcepted, managmentAvgEarningsActual);
            Assert.AreEqual(logisticsAvgEarningsExcepted, logisticsAvgEarningsActual);
            Assert.AreEqual(adminiatrationAvgEarningsExcepted, adminiatrationAvgEarningsActual);
            Assert.AreEqual(marketingAvgEarningsExcepted, marketingAvgEarningsActual);
        }

        [Test]
        public void GetNumberOfEmploymentsInMonths_ReturnArrayWithMonthsCount_Returned()
        {
            int[] numberOfEmployedInMonthsExcepted = new int[] { 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0 };
            int[] numberOFEmployedInMonthsActual = GetNumberOfEmploymentsInMonths();

            Assert.AreEqual(numberOfEmployedInMonthsExcepted, numberOFEmployedInMonthsActual);
        }
    }
}
