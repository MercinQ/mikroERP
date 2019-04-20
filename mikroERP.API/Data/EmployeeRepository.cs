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

        public async Task<Employee> AddEmployee( Employee employee)
        {
           await _context.Employees.AddAsync(employee);
           await _context.SaveChangesAsync();

           return employee;
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

        

    }
}