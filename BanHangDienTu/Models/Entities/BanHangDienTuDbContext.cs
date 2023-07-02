using Microsoft.EntityFrameworkCore;

namespace BanHangDienTu.Models.Entities
{
    public class BanHangDienTuDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
