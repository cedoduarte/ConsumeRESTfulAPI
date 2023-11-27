using ConsumeRESTfulAPI.CQRS.Products.Command.CreateProduct;
using ConsumeRESTfulAPI.CQRS.Products.Command.DeleteProduct;
using ConsumeRESTfulAPI.CQRS.Products.Command.UpdateProduct;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductById;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductByIdEvenDeleted;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductList;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using ConsumeRESTfulAPI.Services.Interface;
using MediatR;

namespace ConsumeRESTfulAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IMediator _mediator;

        public ProductService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> CreateProduct(CreateProductCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteProduct(DeleteProductCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateProduct(UpdateProductCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            try
            {
                return await _mediator.Send(new GetProductByIdQuery()
                {
                    Id = id
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProductViewModel> GetProductByIdEvenDeleted(int id)
        {
            try
            {
                return await _mediator.Send(new GetProductByIdEvenDeletedQuery()
                {
                    Id = id
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductList(GetProductListQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductListIncludeDeleted(GetProductListIncludeDeletedQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
