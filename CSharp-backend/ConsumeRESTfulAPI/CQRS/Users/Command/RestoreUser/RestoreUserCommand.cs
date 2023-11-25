using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.RestoreUser
{
    public class RestoreUserCommand : IRequest<bool>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmedPassword { get; set; }
        public int CurrentUserId { get; set; }
    }
}
