using Microsoft.EntityFrameworkCore;
using WorkplaceSystem.Data;
using WorkplaceSystem.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<BankContext>(a => a.UseSqlServer(
    "Server=ACERASPIRE;Database=Db_WorkplaceSystem;User id=sa;Password=2610#Gabi;Encrypt=False"));

builder.Services.AddScoped<IClientRepository, ClientRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Client}/{action=Index}/{id?}");

app.Run();
