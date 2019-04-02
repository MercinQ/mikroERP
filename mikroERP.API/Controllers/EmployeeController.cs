using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mikroERP.API.Data;

namespace mikroERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employeeToReturn = await _repo.GetEmployee(id);

            return Ok(employeeToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employeeToReturn = await _repo.GetEmployees();
            return Ok(employeeToReturn);
        }
    }
}