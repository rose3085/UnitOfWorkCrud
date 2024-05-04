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

        //public Task<UserModel> GetAll(UserDto userDto)
        //{
        //    UserModel userModel = _mapper.Map<UserModel>(userDto);
        //}

        //public async Task<UserModel> GetAll(UserDto userDto)
        //{
        //    var users = await _context.User

        //        .Where(u => u.Name.Contains(userDto.Name)) 
        //        .ToListAsync();
        //    var userDto = _mapper.Map<List<UserDto>>(users);

        //    return userDto;
        //}
        //public async Task<UserModel> GetAllUser(UserDto userDto)
        //{
        //    var user = _mapper.Map<UserModel>(userDto);
        //    await _context.Set<UserModel>().AddAsync(user);
        //    await _context.SaveChangesAsync();
        //}
    }
}
