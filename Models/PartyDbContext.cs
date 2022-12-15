using Microsoft.EntityFrameworkCore;

namespace FirstAsp.Models
{
    public class PartyDbContext : DbContext
    {
        public PartyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<GuestResponse> GuestResponses=>Set<GuestResponse>();
    }
}
