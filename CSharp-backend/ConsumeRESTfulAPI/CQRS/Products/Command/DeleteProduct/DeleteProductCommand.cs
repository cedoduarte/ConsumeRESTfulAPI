using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Products.Command.DeleteProduct
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int CurrentUserId { get; set; }
    }
}
