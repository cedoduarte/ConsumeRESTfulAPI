using ConsumeRESTfulAPI.CQRS.Devices.Command.CreateDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Command.DeleteDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Command.UpdateDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceById;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceByIdEvenDeleted;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceList;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using ConsumeRESTfulAPI.Services.Interface;
using MediatR;

namespace ConsumeRESTfulAPI.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IMediator _mediator;

        public DeviceService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> CreateDevice(CreateDeviceCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteDevice(DeleteDeviceCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateDevice(UpdateDeviceCommand command)
        {
            try
            {
                return await _mediator.Send(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DeviceViewModel> GetDeviceById(int id)
        {
            try
            {
                return await _mediator.Send(new GetDeviceByIdQuery()
                {
                    Id = id
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DeviceViewModel> GetDeviceByIdEvenDeleted(int id)
        {
            try
            {
                return await _mediator.Send(new GetDeviceByIdEvenDeletedQuery()
                {
                    Id = id
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<DeviceViewModel>> GetDeviceList(GetDeviceListQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<DeviceViewModel>> GetDeviceListIncludeDeleted(GetDeviceListIncludeDeletedQuery query)
        {
            try
            {
                return await _mediator.Send(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
