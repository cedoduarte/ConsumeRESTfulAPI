using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Products.Query.GetProductById
{
    public class GetProductByIdQuery : IRequest<ProductViewModel>
    {
        public int Id { get; set; }
    }
}
