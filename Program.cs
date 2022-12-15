using FirstAsp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PartyDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:PartyConnection"]);
});
builder.Services.AddScoped<IPartyRepository, Repository>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapDefaultControllerRoute();
SeedData.EnsurePopulated(app);
app.Run();
