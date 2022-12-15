using Microsoft.EntityFrameworkCore;

namespace FirstAsp.Models
{
    public class PartyDbContext : DbContext
    {
        public PartyDbContext(DbContextOptions<PartyDbContext> options) : base(options)
        {

        }
        public DbSet<GuestResponse> GuestResponses=>Set<GuestResponse>();
    }
}
