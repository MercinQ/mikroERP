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
        
    }
}