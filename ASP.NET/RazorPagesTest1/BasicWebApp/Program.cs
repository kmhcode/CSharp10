using BasicWebApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICounterService, SimpleCounter>();
builder.Services.AddRazorPages();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseEndpoints(endpoints =>
{
	endpoints.MapRazorPages();
});

app.Run();
