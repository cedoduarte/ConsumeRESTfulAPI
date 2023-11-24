using AutoMapper;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using ConsumeRESTfulAPI.Model.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceList
{
    public class GetDeviceListHandler : IRequestHandler<GetDeviceListQuery, IEnumerable<DeviceViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAppDbContext _dbContext;

        public GetDeviceListHandler(IMapper mapper, IAppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<DeviceViewModel>> Handle(GetDeviceListQuery query, CancellationToken cancel)
        {
            try
            {
                if (query.GetAll)
                {
                    return _mapper.Map<IEnumerable<DeviceViewModel>>(await _dbContext.Devices
                        .Where(device => !device.IsDeleted)
                        .ToListAsync(cancel));
                }
                if (!string.IsNullOrEmpty(query.Keyword))
                {
                    return _mapper.Map<IEnumerable<DeviceViewModel>>(await _dbContext.Devices
                        .Where(device => !device.IsDeleted
                                         && (
                                         !string.IsNullOrEmpty(device.Name) && device.Name.ToLower().Contains(query.Keyword.ToLower().Trim())
                                         || !string.IsNullOrEmpty(device.User!.Name) && device.User.Name.ToLower().Contains(query.Keyword.ToLower().Trim())))
                        .Include(device => device.User)
                        .ToListAsync(cancel));
                }
                throw new Exception("The keyword cannot be empty!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
