using Bistros.Core.Application.Interfaces;
using Bistros.Core.Application.Services;
using Bistros.Infrastructure.Persistance;
using Bistros.Infrastructure.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnection")));

builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
