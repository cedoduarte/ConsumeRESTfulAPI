using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserByIdEvenDeleted
{
    public class GetUserByIdEvenDeletedHandler : IRequestHandler<GetUserByIdEvenDeletedQuery, UserViewModel>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetUserByIdEvenDeletedHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<UserViewModel> Handle(GetUserByIdEvenDeletedQuery query, CancellationToken cancel)
        {
            try
            {
                User? foundUser = await _dbContext.Users
                    .Where(user => user.Id == query.Id)
                    .Include(user => user.CurrentUser)
                    .FirstOrDefaultAsync(cancel);
                if (foundUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {query.Id} not exists!");
                }
                return _mapper.Map<UserViewModel>(foundUser);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
