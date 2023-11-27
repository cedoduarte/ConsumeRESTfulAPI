using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Products.Query.GetProductByIdEvenDeleted
{
    public class GetProductByIdEvenDeletedHandler : IRequestHandler<GetProductByIdEvenDeletedQuery, ProductViewModel>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetProductByIdEvenDeletedHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<ProductViewModel> Handle(GetProductByIdEvenDeletedQuery query, CancellationToken cancel)
        {
            try
            {
                Product? existingProduct = await _dbContext.Products
                    .Where(product => product.Id == query.Id)
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
