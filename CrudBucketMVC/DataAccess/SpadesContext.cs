using Microsoft.EntityFrameworkCore;

namespace SpadesDataProject.DataAccess
{
    public class SpadesContext : DbContext
    {
        public SpadesContext(DbContextOptions<SpadesContext> options) : base(options)
        {
            
        }
    }
}
