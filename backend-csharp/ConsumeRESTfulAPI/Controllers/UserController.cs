using ConsumeRESTfulAPI.CQRS.Users.Command.ChangePassword;
using ConsumeRESTfulAPI.CQRS.Users.Command.CreateUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.DeleteUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.RestoreUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.UpdateUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.UpdateUserEvenDeleted;
using ConsumeRESTfulAPI.CQRS.Users.Query.GetUserList;
using ConsumeRESTfulAPI.CQRS.Users.Query.GetUserListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Users.Query.LogIn;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeRESTfulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("change-password")]
        public async Task<bool> ChangePassword([FromBody] ChangePasswordCommand command)
        {
            try
            {
                return await _userService.ChangePassword(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("create-user")]
        public async Task<bool> CreateUser([FromBody] CreateUserCommand command)
        {
            try
            {
                return await _userService.CreateUser(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("delete-user/{id}/{currentUserId}")]
        public async Task<bool> DeleteUser([FromRoute] int id, [FromRoute] int currentUserId)
        {
            try
            {
                return await _userService.DeleteUser(new DeleteUserCommand()
                {
                    Id = id,
                    CurrentUserId = currentUserId
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("restore-user")]
        public async Task<bool> RestoreUser([FromBody] RestoreUserCommand command)
        {
            try
            {
                return await _userService.RestoreUser(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("update-user")]
        public async Task<bool> UpdateUser([FromBody] UpdateUserCommand command)
        {
            try
            {
                return await _userService.UpdateUser(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("update-user-even-deleted")]
        public async Task<bool> UpdateUserEvenDeleted([FromBody] UpdateUserEvenDeletedCommand command)
        {
            try
            {
                return await _userService.UpdateUserEvenDeleted(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-user-by-id/{id}")]
        public async Task<UserViewModel> GetUserById([FromRoute] int id)
        {
            try
            {
                return await _userService.GetUserById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-user-by-id-even-deleted/{id}")]
        public async Task<UserViewModel> GetUserByIdEvenDeleted([FromRoute] int id)
        {
            try
            {
                return await _userService.GetUserByIdEvenDeleted(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-user-list")]
        public async Task<IEnumerable<UserViewModel>> GetUserList([FromQuery] GetUserListQuery query)
        {
            try
            {
                return await _userService.GetUserList(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-user-list-include-deleted")]
        public async Task<IEnumerable<UserViewModel>> GetUserListIncludeDeleted([FromQuery] GetUserListIncludeDeletedQuery query)
        {
            try
            {
                return await _userService.GetUserListIncludeDeleted(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("login")]
        public async Task<bool> LogIn([FromBody] LogInCommand command)
        {
            try
            {
                return await _userService.LogIn(command);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
