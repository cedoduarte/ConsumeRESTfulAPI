namespace ConsumeRESTfulAPI.Model
{
    public class Device
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? InsertedDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateTime { get; set; } = DateTime.Now;
        public DateTime? DeletedDateTime { get; set; }
        public virtual User? CurrentUser { get; set; }
        public int CurrentUserId { get; set; }
    }
}
