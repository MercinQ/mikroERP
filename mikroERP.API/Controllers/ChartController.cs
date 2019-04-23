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
            var GenderCountChartDto = new GenderCountChartDto()
            {
                MenCount = _repo.GetManCount(),
                WomanCount = _repo.GetWomanCount()
            };

            return Ok(GenderCountChartDto);
        }
    }
}