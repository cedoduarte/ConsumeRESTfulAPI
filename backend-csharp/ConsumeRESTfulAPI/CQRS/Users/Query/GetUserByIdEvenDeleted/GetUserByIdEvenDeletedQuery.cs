using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserByIdEvenDeleted
{
    public class GetUserByIdEvenDeletedQuery : IRequest<UserViewModel>
    {
        public int Id { get; set; }
    }
}
