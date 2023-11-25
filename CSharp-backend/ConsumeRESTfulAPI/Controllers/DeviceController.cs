using ConsumeRESTfulAPI.CQRS.Devices.Command.CreateDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Command.DeleteDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Command.UpdateDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceList;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using ConsumeRESTfulAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeRESTfulAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : Controller
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpPost("create-device")]
        public async Task<bool> CreateDevice([FromBody] CreateDeviceCommand command)
        {
            try
            {
                return await _deviceService.CreateDevice(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("delete-device/{id}/{currentUserId}")]
        public async Task<bool> DeleteDevice([FromRoute] int id, [FromRoute] int currentUserId)
        {
            try
            {
                return await _deviceService.DeleteDevice(new DeleteDeviceCommand()
                {
                    Id = id,
                    CurrentUserId = currentUserId
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("update-device")]
        public async Task<bool> UpdateDevice([FromBody] UpdateDeviceCommand command)
        {
            try
            {
                return await _deviceService.UpdateDevice(command);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-device-by-id/{id}")]
        public async Task<DeviceViewModel> GetDeviceById([FromRoute] int id)
        {
            try
            {
                return await _deviceService.GetDeviceById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-device-by-id-even-deleted/{id}")]
        public async Task<DeviceViewModel> GetDeviceByIdEvenDeleted([FromRoute] int id)
        {
            try
            {
                return await _deviceService.GetDeviceByIdEvenDeleted(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-device-list")]
        public async Task<IEnumerable<DeviceViewModel>> GetDeviceList([FromQuery] GetDeviceListQuery query)
        {
            try
            {
                return await _deviceService.GetDeviceList(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("get-device-list-include-deleted")]
        public async Task<IEnumerable<DeviceViewModel>> GetDeviceListIncludeDeleted([FromQuery] GetDeviceListIncludeDeletedQuery query)
        {
            try
            {
                return await _deviceService.GetDeviceListIncludeDeleted(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
