using Microsoft.EntityFrameworkCore;

namespace EREticaret.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }
    }
}
