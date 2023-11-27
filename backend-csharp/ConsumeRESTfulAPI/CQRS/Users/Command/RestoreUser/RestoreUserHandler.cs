using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.RestoreUser
{
    public class RestoreUserHandler : IRequestHandler<RestoreUserCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public RestoreUserHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(RestoreUserCommand command, CancellationToken cancel)
        {
            try
            {
                if (string.IsNullOrEmpty(command.Email))
                {
                    throw new Exception("The email cannot be empty!");
                }
                if (!Util.IsEmail(command.Email))
                {
                    throw new Exception("The email is invalid!");
                }
                if (string.IsNullOrEmpty(command.Password))
                {
                    throw new Exception("The password cannot be empty!");
                }
                if (string.IsNullOrEmpty(command.ConfirmedPassword))
                {
                    throw new Exception("The confirmed password cannot be empty!");
                }
                if (!string.Equals(command.Password, command.ConfirmedPassword))
                {
                    throw new Exception("The password and confirmed password are not the same!");
                }

                // checks the current user exists
                User? currentUser = await _dbContext.Users
                    .Where(user => user.Id == command.CurrentUserId && !user.IsDeleted)
                    .FirstOrDefaultAsync(cancel);
                if (currentUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {command.CurrentUserId} not exists!");
                }

                User? foundUser = await _dbContext.Users
                    .Where(user => user.IsDeleted 
                                   && user.Email == command.Email 
                                   && user.Password == Util.ToSHA256(command.Password))
                    .FirstOrDefaultAsync(cancel);
                if (foundUser is null)
                {
                    throw new Exception($"{nameof(User)} with Email {command.Email} cannot be found to be restored!");
                }
                foundUser.IsDeleted = false;
                foundUser.UpdatedDateTime = DateTime.Now;
                foundUser.CurrentUserId = command.CurrentUserId;
                _dbContext.Users.Update(foundUser);
                await _dbContext.SaveChangesAsync(cancel);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
