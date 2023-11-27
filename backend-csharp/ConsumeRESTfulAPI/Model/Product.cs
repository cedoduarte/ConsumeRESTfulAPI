namespace ConsumeRESTfulAPI.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? InsertedDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateTime { get; set; } = DateTime.Now;
        public DateTime? DeletedDateTime { get; set; }
        public virtual User? CurrentUser { get; set; }
        public int CurrentUserId { get; set; }
    }
}
