using ConsumeRESTfulAPI.CQRS.Devices.Command.CreateDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Command.DeleteDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Command.UpdateDevice;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceList;
using ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceListIncludeDeleted;
using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;

namespace ConsumeRESTfulAPI.Services.Interface
{
    public interface IDeviceService
    {
        Task<bool> CreateDevice(CreateDeviceCommand command);
        Task<bool> DeleteDevice(DeleteDeviceCommand command);
        Task<bool> UpdateDevice(UpdateDeviceCommand command);
        Task<DeviceViewModel> GetDeviceById(int id);
        Task<DeviceViewModel> GetDeviceByIdEvenDeleted(int id);
        Task<IEnumerable<DeviceViewModel>> GetDeviceList(GetDeviceListQuery query);
        Task<IEnumerable<DeviceViewModel>> GetDeviceListIncludeDeleted(GetDeviceListIncludeDeletedQuery query);
    }
}
