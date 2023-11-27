using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Devices.Command.CreateDevice
{
    public class CreateDeviceHandler : IRequestHandler<CreateDeviceCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public CreateDeviceHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(CreateDeviceCommand command, CancellationToken cancel)
        {
            try
            {
                if (string.IsNullOrEmpty(command.Name))
                {
                    throw new Exception("The name cannot be empty!");
                }

                // checks the current user exists
                User? currentUser = await _dbContext.Users
                    .Where(user => user.Id == command.CurrentUserId && !user.IsDeleted)
                    .FirstOrDefaultAsync(cancel);
                if (currentUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {command.CurrentUserId} not exists!");
                }

                await _dbContext.Devices.AddAsync(new Device()
                {
                    Name = command.Name,
                    UserId = command.UserId,
                    Price = command.Price,
                    CurrentUserId = command.CurrentUserId
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
