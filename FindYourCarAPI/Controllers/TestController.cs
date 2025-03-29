using FindYourCarAPI.Data.Entities;
using FindYourCarAPI.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;


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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var car = await carService.GetrById(id);
            return car != null ? Ok(car) : NotFound("Car not found. Go get one!!!");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            var createCar = await carService.Create(car);

            return Ok(createCar);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Car car)
        {
            var updatedCar = await carService.Update(car);
            return Ok(updatedCar);
        }

        [HttpDelete("{id}")]  
        public async Task<IActionResult> Delete(int id)
        {
            var reslt = await carService.Delete(id);
            return Ok(reslt);
        
        } 
    }
}
