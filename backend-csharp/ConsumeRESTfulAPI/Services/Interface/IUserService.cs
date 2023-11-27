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

namespace ConsumeRESTfulAPI.Services.Interface
{
    public interface IUserService
    {
        Task<bool> ChangePassword(ChangePasswordCommand command);
        Task<bool> CreateUser(CreateUserCommand command);
        Task<bool> DeleteUser(DeleteUserCommand command);
        Task<bool> RestoreUser(RestoreUserCommand command);
        Task<bool> UpdateUser(UpdateUserCommand command);
        Task<bool> UpdateUserEvenDeleted(UpdateUserEvenDeletedCommand command);
        Task<UserViewModel> GetUserById(int id);
        Task<UserViewModel> GetUserByIdEvenDeleted(int id);
        Task<IEnumerable<UserViewModel>> GetUserList(GetUserListQuery query);
        Task<IEnumerable<UserViewModel>> GetUserListIncludeDeleted(GetUserListIncludeDeletedQuery query);
        Task<bool> LogIn(LogInCommand command);
    }
}
