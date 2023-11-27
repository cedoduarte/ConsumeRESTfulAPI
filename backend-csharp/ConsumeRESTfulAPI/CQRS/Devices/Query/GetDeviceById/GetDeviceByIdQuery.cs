using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceById
{
    public class GetDeviceByIdQuery : IRequest<DeviceViewModel>
    {
        public int Id { get; set; }
    }
}
