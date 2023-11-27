using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.DeleteUser
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int CurrentUserId { get; set; }
    }
}
