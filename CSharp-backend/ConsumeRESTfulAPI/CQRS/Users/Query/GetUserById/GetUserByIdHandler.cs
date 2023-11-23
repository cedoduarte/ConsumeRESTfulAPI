using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IAppDbContext _dbContext;

        public GetUserByIdHandler(IMapper mapper, IAppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<UserViewModel> Handle(GetUserByIdQuery query, CancellationToken cancel)
        {
            try
            {
                User? existingUser = await _dbContext.Users
                    .Where(user => !user.IsDeleted && user.Id == query.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {query.Id} not exists!");
                }
                return _mapper.Map<UserViewModel>(existingUser);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
