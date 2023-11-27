using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.ChangePassword
{
    public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public ChangePasswordHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // the user changes his password by himself
        public async Task<bool> Handle(ChangePasswordCommand command, CancellationToken cancel)
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
                if (string.IsNullOrEmpty(command.CurrentPassword))
                {
                    throw new Exception("The current password cannot be empty!");
                }
                if (string.IsNullOrEmpty(command.NewPassword))
                {
                    throw new Exception("The new password cannot be empty!");
                }
                if (string.IsNullOrEmpty(command.ConfirmedPassword))
                {
                    throw new Exception("The confirmed password cannot be empty!");
                }
                if (!string.Equals(command.NewPassword, command.ConfirmedPassword))
                {
                    throw new Exception("The passwords are not the same!");
                }
                string currentPasswordHash = Util.ToSHA256(command.CurrentPassword);
                User? existingUser = await _dbContext.Users
                    .Where(user => !user.IsDeleted 
                                   && string.Equals(user.Email, command.Email) 
                                   && string.Equals(user.Password, currentPasswordHash))
                    .FirstOrDefaultAsync(cancel);
                if (existingUser is null)
                {
                    throw new Exception($"{nameof(User)} with email {command.Email} not exists!");
                }
                string newPasswordHash = Util.ToSHA256(command.NewPassword);
                existingUser.Password = newPasswordHash;
                existingUser.UpdatedDateTime = DateTime.Now;
                existingUser.CurrentUserId = existingUser.Id;
                _dbContext.Users.Update(existingUser);
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
