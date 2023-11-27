using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceListIncludeDeleted
{
    public class GetDeviceListIncludeDeletedQuery : IRequest<IEnumerable<DeviceViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
