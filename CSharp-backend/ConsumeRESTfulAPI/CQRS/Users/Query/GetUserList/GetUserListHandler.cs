using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, IEnumerable<UserViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetUserListHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserViewModel>> Handle(GetUserListQuery query, CancellationToken cancel)
        {
            try
            {
                if (query.GetAll)
                {
                    return _mapper.Map<IEnumerable<UserViewModel>>(await _dbContext.Users
                        .Where(user => !user.IsDeleted)
                        .Include(user => user.CurrentUser)
                        .ToListAsync(cancel));
                }
                if (!string.IsNullOrEmpty(query.Keyword))
                {
                    return _mapper.Map<IEnumerable<UserViewModel>>(await _dbContext.Users
                        .Where(user => !user.IsDeleted
                            && (
                                    (
                                        string.IsNullOrEmpty(user.Name) ? false : user.Name.ToLower().Contains(query.Keyword.ToLower().Trim())
                                    )
                                    || 
                                    (
                                        string.IsNullOrEmpty(user.Email) ? false : user.Email.ToLower().Contains(query.Keyword.ToLower().Trim())
                                    )
                                    || 
                                    (
                                        user.Birthdate == null ? false : user.Birthdate.ToString().ToLower().Contains(query.Keyword.ToLower().Trim())
                                    )
                                    ||
                                    (
                                        string.IsNullOrEmpty(user.Address) ? false : user.Address.ToLower().Contains(query.Keyword.ToLower().Trim())
                                    )
                                    ||
                                    (
                                        string.IsNullOrEmpty(user.Country) ? false : user.Country.ToLower().Contains(query.Keyword.ToLower().Trim())
                                    )
                                    ||
                                    (
                                        string.IsNullOrEmpty(user.City) ? false : user.City.ToLower().Contains(query.Keyword.ToLower().Trim())
                                    )
                                    ||
                                    user.Salary.ToString().Contains(query.Keyword.ToLower().Trim())
                                )
                            )
                        .Include(user => user.CurrentUser)
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
