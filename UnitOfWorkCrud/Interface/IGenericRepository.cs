using System.Linq.Expressions;

namespace UnitOfWorkCrud.Interface
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> GetById(int id);
        //Task<T> GetAll(Expression<Func<T, bool>> expression = null,List<string>includes = null);
        Task AddUser(T entities);
        Task<IEnumerable<T>> GetAllAsync();

    }
}
