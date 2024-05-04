using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkCrud.DTO;
using UnitOfWorkCrud.Interface;
using UnitOfWorkCrud.Model;

namespace UnitOfWorkCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> AddUser(UserDto model)
        {
            var result = await _userService.AddNewUser(model);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult<UserModel>> GetAllUser()
        {
            var result = await _userService.GetAllUser();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();

        }
    }
}
