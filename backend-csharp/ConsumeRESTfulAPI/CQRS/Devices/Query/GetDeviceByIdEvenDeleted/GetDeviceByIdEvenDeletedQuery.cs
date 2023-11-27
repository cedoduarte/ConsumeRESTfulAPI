using ConsumeRESTfulAPI.CQRS.Devices.ViewModel;
using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Query.GetDeviceByIdEvenDeleted
{
    public class GetDeviceByIdEvenDeletedQuery : IRequest<DeviceViewModel>
    {
        public int Id { get; set; }
    }
}
