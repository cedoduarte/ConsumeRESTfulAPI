using ConsumeRESTfulAPI.CQRS.Products.Command.CreateProduct;
using ConsumeRESTfulAPI.CQRS.Products.Command.DeleteProduct;
using ConsumeRESTfulAPI.CQRS.Products.Command.UpdateProduct;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductList;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using ConsumeRESTfulAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeRESTfulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("create-product")]
        public async Task<bool> CreateProduct([FromBody] CreateProductCommand command)
        {
            try
            {
                return await _productService.CreateProduct(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("delete-product/{id}/{currentUserId}")]
        public async Task<bool> DeleteProduct([FromRoute] int id, [FromRoute] int currentUserId)
        {
            try
            {
                return await _productService.DeleteProduct(new DeleteProductCommand()
                {
                    Id = id,
                    CurrentUserId = currentUserId
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("update-product")]
        public async Task<bool> UpdateProduct([FromBody] UpdateProductCommand command)
        {
            try
            {
                return await _productService.UpdateProduct(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-product-by-id/{id}")]
        public async Task<ProductViewModel> GetProductById([FromRoute] int id)
        {
            try
            {
                return await _productService.GetProductById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-product-by-id-even-deleted/{id}")]
        public async Task<ProductViewModel> GetProductByIdEvenDeleted([FromRoute] int id)
        {
            try
            {
                return await _productService.GetProductByIdEvenDeleted(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-product-list")]
        public async Task<IEnumerable<ProductViewModel>> GetProductList([FromQuery] GetProductListQuery query)
        {
            try
            {
                return await _productService.GetProductList(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-product-list-include-deleted")]
        public async Task<IEnumerable<ProductViewModel>> GetProductListIncludeDeleted([FromQuery] GetProductListIncludeDeletedQuery query)
        {
            try
            {
                return await _productService.GetProductListIncludeDeleted(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
