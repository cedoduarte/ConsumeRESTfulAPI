using MediatR;

namespace ConsumeRESTfulAPI.CQRS.Devices.Command.UpdateDevice
{
    public class UpdateDeviceCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public decimal? Price { get; set; }
        public int CurrentUserId { get; set; }
    }
}
