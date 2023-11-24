using Microsoft.EntityFrameworkCore;

namespace ConsumeRESTfulAPI.Model.Interface
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Device> Devices { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
