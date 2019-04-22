using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mikroERP.API.Models;

namespace mikroERP.API.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);

            _context.SaveChanges();
        }

        public async Task<Employee> GetEmployee(int id)
        {
           var employee = _context.Employees
           .Include(d => d.Department.Location)
           .Include(t => t.Transport)
           .FirstOrDefaultAsync(u => u.Id == id);

           return await employee;
        }
        public async Task<List<Employee>> GetEmployees()
        {
            var employees = _context.Employees
            .Include(d => d.Department.Location)
            .Include(t => t.Transport)
            .ToListAsync();
            return await employees;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}