using ConsumeRESTfulAPI.Model;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Products.Command.CreateProduct
{
    public class CreateProductCommand : IRequest<bool>
    {
        public string? Name { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public int CurrentUserId { get; set; }
    }
}
