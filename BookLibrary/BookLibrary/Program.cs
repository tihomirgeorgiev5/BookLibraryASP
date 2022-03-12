using BookLibrary.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString(@"Server=DESKTOP-SB9MJ7T\SQLEXPRESS;Database=BookLibrary;Trusted_Connection=True;Integrated Security=True;");

builder.Services.AddDbContext<BookLibraryDbContext>(options =>
    options.UseSqlServer(@"Server=DESKTOP-SB9MJ7T\SQLEXPRESS;Database=BookLibrary;Trusted_Connection=True;Integrated Security=True;"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
                  {
                      options.Password.RequireDigit = false;
                      options.Password.RequireLowercase = false;
                      options.Password.RequireNonAlphanumeric = false;
                      options.Password.RequireUppercase = false;
                      })
    .AddEntityFrameworkStores<BookLibraryDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection()
   .UseStaticFiles()
   .UseRouting()
   .UseAuthentication()
   .UseAuthorization();


   app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
    
app.MapRazorPages();

app.Run();
