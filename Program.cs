<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages and SQLite database context
builder.Services.AddRazorPages();
builder.Services.AddDbContext<KasperDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("KasperDb")));

var app = builder.Build();

// Create and seed the SQLite database on startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<KasperDbContext>();
    DbInitializer.Initialize(context);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
=======
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
>>>>>>> c02d0b519319d5054ac35f57b16d7759e5ed3101
