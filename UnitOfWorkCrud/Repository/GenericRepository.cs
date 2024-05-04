using UnitOfWorkCrud.Data;
using UnitOfWorkCrud.Interface;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace UnitOfWorkCrud.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
                                                                //where TEntity : class
                                                                //where TDto : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

       

        public async Task AddUser(T entities)
        {
            await _db.AddAsync(entities);
        
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await _db.ToListAsync();
        }

        //public async Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        //{
        //    IQueryable<T> query = _db;
        //    if (include != null)
        //    {
        //        query = include(query);
        //    }

        //    return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        //}


        //public async Task<T> GetAll(Expression<Func<T, bool>> expression = null, List<string> includes = null)
        //{
        //    return await _db.FirstAsync(expression);
        //}

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
