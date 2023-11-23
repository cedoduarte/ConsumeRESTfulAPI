﻿using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Users.ViewModel;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, IEnumerable<UserViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAppDbContext _dbContext;

        public GetUserListHandler(IMapper mapper, IAppDbContext dbContext)
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
                    return _mapper.Map<IEnumerable<UserViewModel>>(
                        await _dbContext.Users
                            .Where(user => !user.IsDeleted)
                            .ToListAsync(cancel));
                }
                if (!string.IsNullOrEmpty(query.Keyword))
                {
                    _mapper.Map<IEnumerable<UserViewModel>>(await _dbContext.Users
                        .Where(user => !user.IsDeleted
                                       && (
                                       !string.IsNullOrEmpty(user.Name) && user.Name.ToLower().Contains(query.Keyword.ToLower())
                                       || !string.IsNullOrEmpty(user.Email) && user.Email.ToLower().Contains(query.Keyword.ToLower())
                                       || !string.IsNullOrEmpty(user.Address) && user.Address.ToLower().Contains(query.Keyword.ToLower())
                                       || !string.IsNullOrEmpty(user.Country) && user.Country.ToLower().Contains(query.Keyword.ToLower())
                                       || !string.IsNullOrEmpty(user.City) && user.City.ToLower().Contains(query.Keyword.ToLower())
                                       || user.Salary.ToString().Contains(query.Keyword.ToLower())                    
                    )).ToListAsync(cancel));
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