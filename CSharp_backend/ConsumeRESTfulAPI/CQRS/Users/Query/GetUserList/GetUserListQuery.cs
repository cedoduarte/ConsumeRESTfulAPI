using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserList
{
    public class GetUserListQuery : IRequest<IEnumerable<UserViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
