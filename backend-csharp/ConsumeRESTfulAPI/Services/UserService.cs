using ConsumeRESTfulAPI.CQRS.Users.Command.ChangePassword;
using ConsumeRESTfulAPI.CQRS.Users.Command.CreateUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.DeleteUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.RestoreUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.UpdateUser;
using ConsumeRESTfulAPI.CQRS.Users.Command.UpdateUserEvenDeleted;
using ConsumeRESTfulAPI.CQRS.Users.Query.GetUserById;
using ConsumeRESTfulAPI.CQRS.Users.Query.GetUserByIdEvenDeleted;
using ConsumeRESTfulAPI.CQRS.Users.Query.GetUserList;
using ConsumeRESTfulAPI.CQRS.Users.Query.GetUserListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Users.Query.LogIn;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Services.Interface;
using MediatR;

namespace ConsumeRESTfulAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IMediator _mediator;

        public UserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> ChangePassword(ChangePasswordCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> CreateUser(CreateUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteUser(DeleteUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> RestoreUser(RestoreUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateUser(UpdateUserCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateUserEvenDeleted(UpdateUserEvenDeletedCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            try
            {
                return await _mediator.Send(new GetUserByIdQuery()
                {
                    Id = id
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<UserViewModel> GetUserByIdEvenDeleted(int id)
        {
            try
            {
                return await _mediator.Send(new GetUserByIdEvenDeletedQuery()
                {
                    Id = id
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserViewModel>> GetUserList(GetUserListQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserViewModel>> GetUserListIncludeDeleted(GetUserListIncludeDeletedQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> LogIn(LogInCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
