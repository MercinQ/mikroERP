using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using mikroERP.API.Data;
using mikroERP.API.Dtos;

namespace mikroERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _repo.GetEmployee(id);
            var employeeToReturn = _mapper.Map<EmployeeForTableDto>(employee);

            return Ok(employeeToReturn);
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _repo.GetEmployees();
            var employeesToReturn = _mapper.Map<IEnumerable<EmployeeForTableDto>>(employees);

            return Ok(employeesToReturn);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _repo.DeleteEmployee(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeForTableDto userForUpdate)
        {
            var employeeToUpdate = await _repo.GetEmployee(id);
            _mapper.Map(userForUpdate,employeeToUpdate);

            if(await _repo.SaveAll()){
                return NoContent();
            }

            throw new Exception($"Updating user {id} failed on save");
        }
    }
}