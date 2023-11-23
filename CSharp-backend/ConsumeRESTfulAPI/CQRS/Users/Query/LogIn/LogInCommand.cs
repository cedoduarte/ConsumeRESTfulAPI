using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.LogIn
{
    public class LogInCommand : IRequest<bool>
    {
        public string? Email {  get; set; }
        public string? Password { get; set; }
    }
}
