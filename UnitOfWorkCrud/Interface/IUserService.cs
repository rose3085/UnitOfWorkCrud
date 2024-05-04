using UnitOfWorkCrud.DTO;
using UnitOfWorkCrud.Model;

namespace UnitOfWorkCrud.Interface
{
    public interface IUserService
    {

        Task<string> AddNewUser(UserDto user);
        Task<IEnumerable<UserModel>> GetAllUser();


    }
}
