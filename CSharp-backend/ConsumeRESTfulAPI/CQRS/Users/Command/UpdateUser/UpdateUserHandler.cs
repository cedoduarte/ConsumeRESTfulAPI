using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public UpdateUserHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(UpdateUserCommand command, CancellationToken cancel)
        {
            try
            {
                if (string.IsNullOrEmpty(command.Name))
                {
                    throw new Exception("The name cannot be empty!");
                }
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
                if (command.Birthdate is null)
                {
                    throw new Exception("The birthdate cannot be empty!");
                }
                if (string.IsNullOrEmpty(command.Address))
                {
                    throw new Exception("The address cannot be empty!");
                }
                if (string.IsNullOrEmpty(command.Country))
                {
                    throw new Exception("The country cannot be empty!");
                }
                if (string.IsNullOrEmpty(command.City))
                {
                    throw new Exception("The city cannot be empty!");
                }

                // checks the current user exists
                User? currentUser = await _dbContext.Users
                    .Where(user => user.Id == command.CurrentUserId && !user.IsDeleted)
                    .FirstOrDefaultAsync(cancel);
                if (currentUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {command.CurrentUserId} not exists!");
                }

                User? existingUser = await _dbContext.Users
                    .Where(user => !user.IsDeleted && user.Id == command.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {command.Id} not exists!");
                }
                existingUser.Name = command.Name;
                existingUser.Email = command.Email;
                existingUser.Password = Util.ToSHA256(command.Password);
                existingUser.Birthdate = command.Birthdate;
                existingUser.Address = command.Address;
                existingUser.Country = command.Country;
                existingUser.City = command.City;
                existingUser.Salary = command.Salary;
                existingUser.UpdatedDateTime = DateTime.Now;
                existingUser.CurrentUserId = command.CurrentUserId;
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
