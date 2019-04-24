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
            int managmentDepCount = _context.Employees.Where(e => e.DepartmentId == 1).Count();
            return managmentDepCount;
        }
        public int GetLogisticsDepCount()
        {
            int logisticsDepCount = _context.Employees.Where(e => e.DepartmentId == 2).Count();
            return logisticsDepCount;
        }

        public int GetAdministrationDepCount()
        {
            int administrationDepCount = _context.Employees.Where(e => e.DepartmentId == 3).Count();
            return administrationDepCount;
        }

        public int GetMarketingDepCount()
        {
            int marketingDepCount = _context.Employees.Where(e => e.DepartmentId == 4).Count();
            return marketingDepCount;
        }

        public int GetManCount()
        {
            int manCount = _context.Employees.Where(e => e.Sex == "M").Count();
            return  manCount;
        }

        public int GetWomanCount()
        {
            int manCount = _context.Employees.Where(e => e.Sex == "F").Count();
            return  manCount;
        }
        public List<DateTime> GetBirthday()
        {
            List<DateTime> birthday = _context.Employees.Select(e => e.DateOfBirth).ToList();
            return birthday;
        }

        public double GetManagmentAvgEarnings()
        {
            double managmentTotalIncome = _context.Employees
            .Where(e => e.DepartmentId == 1)
            .Sum(e => e.Wages);
            double managmentAvgearnings = managmentTotalIncome / GetManagmentDepCount();

            return managmentAvgearnings;
        }

        public double GetLogisticsAvgEarnings()
        {
            double logisticsTotalIncome = _context.Employees
            .Where(e => e.DepartmentId == 2)
            .Sum(e => e.Wages);
            double logisticsAvgearnings = logisticsTotalIncome / GetLogisticsDepCount();

            return logisticsAvgearnings;
        }

        public double GetAdministrationAvgEarnings()
        {
            double administrationTotalIncome = _context.Employees
            .Where(e => e.DepartmentId == 3)
            .Sum(e => e.Wages);
            double administrationAvgearnings = administrationTotalIncome / GetAdministrationDepCount();

            return administrationAvgearnings;
        }

        public double GetMarketingAvgEarnings()
        {
            double marketingTotalIncome = _context.Employees
            .Where(e => e.DepartmentId == 4)
            .Sum(e => e.Wages);
            double marketingAvgearnings = marketingTotalIncome / GetMarketingDepCount();

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
    }
}