using Microsoft.EntityFrameworkCore;

namespace DBOperationswithEfcoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        
    }
}
