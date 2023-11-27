using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Products.ViewModel;
using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Products.Query.GetProductList
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, IEnumerable<ProductViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetProductListHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ProductViewModel>> Handle(GetProductListQuery query, CancellationToken cancel)
        {
            try
            {
                if (query.GetAll)
                {
                    return _mapper.Map<IEnumerable<ProductViewModel>>(await _dbContext.Products
                        .Where(product => !product.IsDeleted)
                        .Include(product => product.CurrentUser)
                        .ToListAsync(cancel));
                }
                if (!string.IsNullOrEmpty(query.Keyword))
                {
                    return _mapper.Map<IEnumerable<ProductViewModel>>(await _dbContext.Products
                        .Where(product => !product.IsDeleted
                        && (
                            (
                                string.IsNullOrEmpty(product.Name) ? false : product.Name.ToLower().Contains(query.Keyword.ToLower().Trim())
                            ) || product.Price.ToString().Contains(query.Keyword.ToLower().Trim()))
                        )
                        .Include(product => product.CurrentUser)
                        .ToListAsync(cancel));
                }
                throw new Exception("The keyword cannot be empty!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
