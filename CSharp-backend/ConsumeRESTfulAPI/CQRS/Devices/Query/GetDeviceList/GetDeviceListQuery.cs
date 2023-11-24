using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceList
{
    public class GetDeviceListQuery : IRequest<IEnumerable<DeviceViewModel>>
    {
        public string? Keyword { get; set; }
        public bool GetAll { get; set; }
    }
}
