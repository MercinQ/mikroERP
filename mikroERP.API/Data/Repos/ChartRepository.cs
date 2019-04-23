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