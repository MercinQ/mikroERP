using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using mikroERP.API.Data;
using mikroERP.API.Dtos;
using mikroERP.API.Models;

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

        [HttpPost("addemployee")]
        public async Task<IActionResult> AddEmployee(EmployeeForAddEmployeeDto employeeForAddEmployeeDto)
        {  

            var employeeToCreate = new Employee 
            {
                FirstName = employeeForAddEmployeeDto.FirstName,
                LastName = employeeForAddEmployeeDto.LastName,
                Sex = employeeForAddEmployeeDto.Sex,
                Email = employeeForAddEmployeeDto.Email,
                Wages = employeeForAddEmployeeDto.Wages,
                DayOfEmployment = employeeForAddEmployeeDto.DayOfEmployment,
                Phone = employeeForAddEmployeeDto.Phone,
                DateOfBirth = employeeForAddEmployeeDto.DateOfBirth,
                DepartmentId = (int)employeeForAddEmployeeDto.DepartmentId,
                TransportId = (int)employeeForAddEmployeeDto.TransportId
            };

            var createdEmployee = await _repo.AddEmployee(employeeToCreate);

            return StatusCode(201);   
        }

    }
}