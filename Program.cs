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
