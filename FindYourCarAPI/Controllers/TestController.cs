using FindYourCarAPI.Services.Services;
using Microsoft.AspNetCore.Mvc;


namespace FindYourCarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ICarService carService;

        public TestController(ILogger<TestController> logger, ICarService carService)
        {
            this.carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cars = await carService.GetAll();
            return Ok(cars);
        }
    }
}
