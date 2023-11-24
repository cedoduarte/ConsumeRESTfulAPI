using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using ConsumeRESTfulAPI.Model;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceById
{
    public class GetDeviceByIdHandler : IRequestHandler<GetDeviceByIdQuery, DeviceViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IAppDbContext _dbContext;

        public GetDeviceByIdHandler(IMapper mapper, IAppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<DeviceViewModel> Handle(GetDeviceByIdQuery query, CancellationToken cancel)
        {
            try
            {
                Device? existingDevice = await _dbContext.Devices
                    .Where(device => !device.IsDeleted && device.Id == query.Id)
                    .FirstOrDefaultAsync(cancel);
                if (existingDevice is null)
                {
                    throw new Exception($"{nameof(Device)} with ID {query.Id} not exists!");
                }
                return _mapper.Map<DeviceViewModel>(existingDevice);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
