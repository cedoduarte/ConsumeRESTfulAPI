namespace ConsumeRESTfulAPI.CQRS.Users.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public decimal Salary { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? InsertedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public UserViewModel? CurrentUser { get; set; }
    }
}
