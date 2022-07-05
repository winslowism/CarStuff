using CarStuff.DAL.Interfaces;
using CarStuff.Models;

namespace CarStuff.DAL.Repositories
{
    public interface IExtraItemRepo : IRepo<ExtraItem>
    {
    }

    public class ExtraItemRepo : IExtraItemRepo
    {
        private readonly CarContext _ctx;

        public ExtraItemRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public ExtraItem Get(int id)
        {
            return _ctx.Extras.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public IEnumerable<ExtraItem> GetAll()
        {
            return _ctx.Extras;
        }
    }
}