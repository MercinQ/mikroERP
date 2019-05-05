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
            return manCount;
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
            double managmentAvgearnings = GetDepAvgEarnings(1, GetManagmentDepCount());

            return managmentAvgearnings;
        }

        public double GetLogisticsAvgEarnings()
        { 
            double logisticsAvgearnings = GetDepAvgEarnings(2, GetLogisticsDepCount());

            return logisticsAvgearnings;
        }

        public double GetAdministrationAvgEarnings()
        {
            double administrationAvgearnings = GetDepAvgEarnings(3, GetAdministrationDepCount());

            return administrationAvgearnings;
        }

        public double GetMarketingAvgEarnings()
        {
            double marketingAvgearnings = GetDepAvgEarnings(4, GetMarketingDepCount());

            return marketingAvgearnings;
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

        private int GetDepartmentCount(int depId)
        {
            return _context.Employees
            .Where(e => e.DepartmentId == depId)
            .Count();
        }

        private int GetGenderCount(string gender)
        {
            return _context.Employees
            .Where(e => e.Sex == gender)
            .Count();
        }

        private double GetDepAvgEarnings(int depId, int depCount)
        {
            if(depCount == 0)
            {
                return 0;
            }
            return _context.Employees
            .Where(e => e.DepartmentId == depId)
            .Sum(e => e.Wages) / depCount;
        }
    }
}