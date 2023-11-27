using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Products.Query.GetProductByIdEvenDeleted
{
    public class GetProductByIdEvenDeletedQuery : IRequest<ProductViewModel>
    {
        public int Id { get; set; }
    }
}
