using BasicWebApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICounterService, SimpleCounter>();
builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", () => "Hello World!");
app.UseRouting();
app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute("default", "{action}/{id}", new {controller = "Greeter", id = "Visitor"});
});

app.Run();
