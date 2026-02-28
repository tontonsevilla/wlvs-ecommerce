using Microsoft.EntityFrameworkCore;
using WLVSEcommerce.Web.Models;

namespace WLVSEcommerce.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
