using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    public class WebApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options) {}
    }
}