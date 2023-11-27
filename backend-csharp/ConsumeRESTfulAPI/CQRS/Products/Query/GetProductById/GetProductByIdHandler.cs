using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Products.Query.GetProductById
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductViewModel>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetProductByIdHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<ProductViewModel> Handle(GetProductByIdQuery query, CancellationToken cancel)
        {
            try
            {
                Product? existingProduct = await _dbContext.Products
                    .Where(product => !product.IsDeleted && product.Id == query.Id)
                    .Include(user => user.CurrentUser)
                    .FirstOrDefaultAsync(cancel);
                if (existingProduct is null)
                {
                    throw new Exception($"{nameof(Product)} with ID {query.Id} not exists!");
                }
                return _mapper.Map<ProductViewModel>(existingProduct);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
