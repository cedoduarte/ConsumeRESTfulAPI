using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Model.Interface;
using ConsumeRESTfulAPI.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Query.LogIn
{
    public class LogInHandler : IRequestHandler<LogInCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public LogInHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(LogInCommand command, CancellationToken cancel)
        {
            try
            {
                if (string.IsNullOrEmpty(command.Email))
                {
                    throw new Exception("The email cannot be empty!");
                }
                if (!Util.IsEmail(command.Email))
                {
                    throw new Exception($"The email: {command.Email} is invalid!");
                }
                if (string.IsNullOrEmpty(command.Password))
                {
                    throw new Exception("The password cannot be empty!");
                }
                return await _dbContext.Users
                    .Where(user => !user.IsDeleted
                                   && user.Email == command.Email
                                   && user.Password == Util.ToSHA256(command.Password))
                    .FirstOrDefaultAsync(cancel) is not null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
