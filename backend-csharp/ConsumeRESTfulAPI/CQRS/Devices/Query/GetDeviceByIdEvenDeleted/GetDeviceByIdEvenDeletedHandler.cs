using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceByIdEvenDeleted
{
    public class GetDeviceByIdEvenDeletedHandler : IRequestHandler<GetDeviceByIdEvenDeletedQuery, DeviceViewModel>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetDeviceByIdEvenDeletedHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<DeviceViewModel> Handle(GetDeviceByIdEvenDeletedQuery query, CancellationToken cancel)
        {
            try
            {
                Device? foundDevice = await _dbContext.Devices
                    .Where(device => device.Id == query.Id)
                    .Include(device => device.User)
                    .Include(device => device.CurrentUser)
                    .FirstOrDefaultAsync(cancel);
                if (foundDevice is null)
                {
                    throw new Exception($"{nameof(Device)} with ID {query.Id} not exists!");
                }
                return _mapper.Map<DeviceViewModel>(foundDevice);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
