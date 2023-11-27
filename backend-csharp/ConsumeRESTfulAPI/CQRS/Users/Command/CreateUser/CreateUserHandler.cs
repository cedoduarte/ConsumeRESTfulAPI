using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Utils;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Users.Command.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public CreateUserHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // the user is created by himself
        public async Task<bool> Handle(CreateUserCommand command, CancellationToken cancel)
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
                if (string.IsNullOrEmpty(command.ConfirmedEmail))
                {
                    throw new Exception("The confirmed email cannot be empty!");
                }
                if (!string.Equals(command.Email, command.ConfirmedEmail))
                {
                    throw new Exception("The email and confirmed email are not the same!");
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
                User? existingUser = await _dbContext.Users
                    .Where(user => !user.IsDeleted && string.Equals(user.Email, command.Email))
                    .FirstOrDefaultAsync(cancel);
                if (existingUser is not null)
                {
                    throw new Exception($"The user with email {existingUser.Email} already exists!");
                }
                await _dbContext.Users.AddAsync(new User()
                {
                    Name = command.Name,
                    Email = command.Email,
                    Password = Util.ToSHA256(command.Password),
                    Birthdate = command.Birthdate,
                    Address = command.Address,
                    Country = command.Country,
                    City = command.City,
                    Salary = command.Salary,
                }, cancel);
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