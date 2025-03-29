using FindYourCarAPI.Data;
using FindYourCarAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FindYourCarAPI.Services.Services
{
    public class CarService : ICarService
    {
        private readonly TestContext context;

        public CarService(TestContext context)
        { 
            this.context = context;
        }

        public async Task<IEnumerable<Car>> GetAll() 
        {
            return await context.Cars.ToListAsync();
        }

        public async Task<Car> GetrById(int id) 
        {
            return await context.Cars.FindAsync(id);
        } 
        public async Task<Car> Create(Car car)
        {
            context.Cars.Add(car);
            await context.SaveChangesAsync();
            return car;
        }
    }

    public interface ICarService
    {
        Task<IEnumerable<Car>> GetAll();
        Task<Car> Create(Car car);  
        Task<Car> GetrById( int id );
    }
}
