using ConsumeRESTfulAPI.CQRS.User.ViewModel;

namespace ConsumeRESTfulAPI.CQRS.Device.ViewModel
{
    public class DeviceViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public virtual UserViewModel? User { get; set; }
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? InsertedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int CurrentUserId { get; set; }
        public virtual UserViewModel? CurrentUser { get; set; }
    }
}
