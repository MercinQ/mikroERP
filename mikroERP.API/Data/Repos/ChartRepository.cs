using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mikroERP.API.Data
{
    public class ChartRepository : IChartRepository
    {
        private readonly DataContext _context;
        public ChartRepository(DataContext context)
        {
            _context = context;
        }

        public int GetManagmentDepCount()
        {
            int managmentDepCount = GetDepartmentCount(1);
            return managmentDepCount;
        }
        public int GetLogisticsDepCount()
        {
            int logisticsDepCount = GetDepartmentCount(2);
            return logisticsDepCount;
        }

        public int GetAdministrationDepCount()
        {
            int administrationDepCount = GetDepartmentCount(3);
            return administrationDepCount;
        }

        public int GetMarketingDepCount()
        {
            int marketingDepCount = GetDepartmentCount(4);
            return marketingDepCount;
        }

        public int GetManCount()
        {
            int manCount = GetGenderCount("M");
            return  manCount;
        }

        public int GetWomanCount()
        {
            int womanCount = GetGenderCount("F");
            return womanCount;
        }
        public List<DateTime> GetBirthday()
        {
            List<DateTime> birthday = _context.Employees.Select(e => e.DateOfBirth).ToList();
            return birthday;
        }

        public double GetManagmentAvgEarnings()
        {
            double managmentAvgEarnigs= GetDepartmentAvgEarnigs(1, GetManagmentDepCount());

            return managmentAvgEarnigs;
        }

        public double GetLogisticsAvgEarnings()
        {
            double logisticsAvgEarnigs = GetDepartmentAvgEarnigs(2, GetLogisticsDepCount());

            return logisticsAvgEarnigs;
        }

        public double GetAdministrationAvgEarnings()
        {
            double administrationAvgEarnigs = GetDepartmentAvgEarnigs(3, GetAdministrationDepCount());

            return administrationAvgEarnigs;
        }

        public double GetMarketingAvgEarnings()
        {
            double marketingAvgEarnigs = GetDepartmentAvgEarnigs(4, GetMarketingDepCount());

            return marketingAvgEarnigs;
        }

        public int[] GetNumberOfEmploymentsInMonths()
        {
            int[] numberOfEmployedInMonths = new int[12];

            for (int i = 1; i <= 12; i++)
            {
               int numberInMonth = _context.Employees
               .Where(e => e.DayOfEmployment.Month == i)
               .Count();
                numberOfEmployedInMonths[i - 1] = numberInMonth;
            }
            return numberOfEmployedInMonths;
        }

        public int GetDepartmentCount(int depId)
        {
            return _context.Employees
                .Where(e => e.DepartmentId == depId).Count();
        }
        public int GetGenderCount(string gender)
        {
            return _context.Employees
                .Where(e => e.Sex == gender).Count();
        }

        public double GetDepartmentAvgEarnigs(int departmentId, int DepartmentCount)
        {
            return _context.Employees
            .Where(e => e.DepartmentId == departmentId)
            .Sum(e => e.Wages) / DepartmentCount;
        }
    }
}