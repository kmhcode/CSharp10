using ModernWebApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlite("FileName=shop.db"));
builder.Services.AddScoped<ShopModel>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/rest/time/now", () => DateTime.Now.ToString());
app.UseFileServer();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

app.Run();
