using BasicWebApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICounterService, CyclicCounter>()
			.Configure<CyclicCounterOptions>(option => option.Limit = 5);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", () => "Hello World!");
app.UseMiddleware<Pausing>();
app.UseRouting();
app.MapGet("/Greet/{person=Visitor}", Greeting.Welcome);

app.Run();
