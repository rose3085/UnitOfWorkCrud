using AutoMapper;
using UnitOfWorkCrud.DTO;
using UnitOfWorkCrud.Model;

namespace UnitOfWorkCrud.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, UserModel>();
        }

    }
}
