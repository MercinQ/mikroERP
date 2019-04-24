using Microsoft.AspNetCore.Mvc;
using mikroERP.API.Data;
using mikroERP.API.Dtos;

namespace mikroERP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IChartRepository _repo;
        public ChartController(IChartRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetGenderCount")]
        public IActionResult GetGenderCount()
        {
            var genderCountChartDto = new GenderCountChartDto()
            {
                MenCount = _repo.GetManCount(),
                WomanCount = _repo.GetWomanCount()
            };

            return Ok(genderCountChartDto);
        }

        [HttpGet]
        [Route("GetDepartmetsCount")]
        public IActionResult GetDepartmetsCount()
        {
            var departmentCountChartDto = new DepartmentCountChartDto()
            {
                ManagmentDepCount = _repo.GetManagmentDepCount(),
                LogisticsDepCount = _repo.GetLogisticsDepCount(),
                AdministrationDepCount = _repo.GetAdministrationDepCount(),
                MarketingDepCount = _repo.GetMarketingDepCount()
            };

            return Ok(departmentCountChartDto);
        }

        [HttpGet]
        [Route("GetDepartmetsAvgEarnings")]
        public IActionResult GetDepartmetsAvgEarnings()
        {
            var departmentAvgEarningDto = new DepartmentAvgEarningDto()
            {
                ManagmentAvgEarnings = _repo.GetManagmentAvgEarnings(),
                LogisticAvgEarnings = _repo.GetLogisticsAvgEarnings(),
                AdministrationAvgEarnings = _repo.GetAdministrationAvgEarnings(),
                MarketingAvgEarnings = _repo.GetMarketingAvgEarnings()
            };

            return Ok(departmentAvgEarningDto);
        }


    }
}