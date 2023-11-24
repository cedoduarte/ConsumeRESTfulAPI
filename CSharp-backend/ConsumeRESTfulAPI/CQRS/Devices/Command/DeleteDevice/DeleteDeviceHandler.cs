using ConsumeRESTfulAPI.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Devices.Command.DeleteDevice
{
    public class DeleteDeviceHandler : IRequestHandler<DeleteDeviceCommand, bool>
    {
        private readonly AppDbContext _dbContext;

        public DeleteDeviceHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteDeviceCommand command, CancellationToken cancel)
        {
            try
            {
                Device? existingDevice = await _dbContext.Devices
                    .Where(device => !device.IsDeleted && device.Id == command.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingDevice is null)
                {
                    throw new Exception($"{nameof(Device)} with ID {command.Id} not exists!");
                }
                existingDevice.IsDeleted = true;
                existingDevice.DeletedDateTime = DateTime.Now;
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
