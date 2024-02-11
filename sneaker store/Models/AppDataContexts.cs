using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace sneaker_store.Models
{
	public class AppDataContexts : IdentityDbContext<AppUser>
	{
		public AppDataContexts(DbContextOptions<AppDataContexts> options) : base(options) { }
		public DbSet<Product> Products { get; set; }
        
    }
}
