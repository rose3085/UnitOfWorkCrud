using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkCrud.Data;
using UnitOfWorkCrud.DTO;
using UnitOfWorkCrud.Interface;
using UnitOfWorkCrud.Model;

namespace UnitOfWorkCrud.Repository
{
    public class UserRepository : GenericRepository<UserModel>, IUserRepository
    {
       
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        //public async Task AddUser(UserDto userDto)
        //{
        //    var user = _mapper.Map<UserModel>(userDto);
        //    //await _context.Set<UserModel>().AddAsync(user);
        //    //await _context.SaveChangesAsync();
        //}

        
    }
}
