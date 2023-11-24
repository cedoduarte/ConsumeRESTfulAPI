using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Devices.Command.UpdateDevice
{
    public class UpdateDeviceHandler : IRequestHandler<UpdateDeviceCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public UpdateDeviceHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(UpdateDeviceCommand command, CancellationToken cancel)
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

                Device? existingDevice = await _dbContext.Devices
                    .Where(device => !device.IsDeleted && device.Id == command.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingDevice is null)
                {
                    throw new Exception($"{nameof(Device)} with ID {command.Id} not exists!");
                }
                existingDevice.Name = command.Name;
                existingDevice.UserId = command.UserId;
                existingDevice.Price = command.Price;
                existingDevice.UpdatedDateTime = DateTime.Now;
                existingDevice.CurrentUserId = command.CurrentUserId;
                _dbContext.Devices.Update(existingDevice);
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
