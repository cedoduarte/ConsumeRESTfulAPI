using ConsumeRESTfulAPI.CQRS.Products.Command.CreateProduct;
using ConsumeRESTfulAPI.CQRS.Products.Command.DeleteProduct;
using ConsumeRESTfulAPI.CQRS.Products.Command.UpdateProduct;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductList;
using ConsumeRESTfulAPI.CQRS.Products.Query.GetProductListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;

namespace ConsumeRESTfulAPI.Services.Interface
{
    public interface IProductService
    {
        Task<bool> CreateProduct(CreateProductCommand command);
        Task<bool> DeleteProduct(DeleteProductCommand command);
        Task<bool> UpdateProduct(UpdateProductCommand command);
        Task<ProductViewModel> GetProductById(int id);
        Task<ProductViewModel> GetProductByIdEvenDeleted(int id);
        Task<IEnumerable<ProductViewModel>> GetProductList(GetProductListQuery query);
        Task<IEnumerable<ProductViewModel>> GetProductListIncludeDeleted(GetProductListIncludeDeletedQuery query);
    }
}
