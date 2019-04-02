using System.Collections.Generic;
using System.Threading.Tasks;
using mikroERP.API.Models;

namespace mikroERP.API.Data
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(int id);
        Task<List<Employee>> GetEmployees();
    }
}