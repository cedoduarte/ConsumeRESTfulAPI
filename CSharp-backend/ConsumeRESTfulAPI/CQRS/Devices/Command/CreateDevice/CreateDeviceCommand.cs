using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Command.CreateDevice
{
    public class CreateDeviceCommand : IRequest<bool>
    {
        public string? Name { get; set; }
        public int UserId { get; set; } // device owner
        public decimal? Price { get; set; }
        public int CurrentUserId { get; set; } // user's id who is creating a new device
    }
}
