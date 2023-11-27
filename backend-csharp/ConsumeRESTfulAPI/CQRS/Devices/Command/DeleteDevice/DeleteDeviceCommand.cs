using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Command.DeleteDevice
{
    public class DeleteDeviceCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int CurrentUserId { get; set; }
    }
}
