using CarStuff.DAL.Interfaces;
using CarStuff.Models;

namespace CarStuff.DAL.Repositories
{
    public interface ICarRepo : IRepo<Car>
    {
    }

    public class CarRepo : ICarRepo
    {
        private readonly CarContext _ctx;

        public CarRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public Car Get(int id)
        {
            return _ctx.Cars.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public IEnumerable<Car> GetAll()
        {
            return _ctx.Cars;
        }
    }
}