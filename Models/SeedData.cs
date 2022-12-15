using Microsoft.EntityFrameworkCore;

namespace FirstAsp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PartyDbContext context = app.ApplicationServices
              .CreateScope().ServiceProvider.GetRequiredService<PartyDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.GuestResponses.Any())
            {
                context.GuestResponses.AddRange
                (
                    new GuestResponse
                    {
                        Name="Masha",Email="Masha@inbox.ru",Phone="123456",WillAttend=true
                    },
                    new GuestResponse
                    {
                        Name = "Misha",
                        Email = "Misha@inbox.ru",
                        Phone = "654321",
                        WillAttend = false
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
