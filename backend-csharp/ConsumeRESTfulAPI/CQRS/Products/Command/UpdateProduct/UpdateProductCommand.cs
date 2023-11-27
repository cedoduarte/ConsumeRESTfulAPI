using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Products.Command.UpdateProduct
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public int CurrentUserId { get; set; }
    }
}
