namespace ConsumeRESTfulAPI.Model
{
    public class User
    {   
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address {  get; set; }
        public string? Country {  get; set; }
        public string? City { get; set; }
        public decimal Salary {  get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? InsertedDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateTime { get; set; } = DateTime.Now;
        public DateTime? DeletedDateTime { get; set; }
        public virtual User? CurrentUser { get; set; }
        public int CurrentUserId { get; set; }
    }
}
