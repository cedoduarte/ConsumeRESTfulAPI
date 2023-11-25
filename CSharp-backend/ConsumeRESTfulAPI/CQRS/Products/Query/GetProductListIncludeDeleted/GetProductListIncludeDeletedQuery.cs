using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Products.Query.GetProductListIncludeDeleted
{
    public class GetProductListIncludeDeletedQuery : IRequest<IEnumerable<ProductViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
