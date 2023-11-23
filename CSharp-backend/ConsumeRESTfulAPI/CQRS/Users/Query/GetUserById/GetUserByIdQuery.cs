using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserViewModel>
    {
        public int Id { get; set; }
    }
}
