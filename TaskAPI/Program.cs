using TaskAPI.Service;
using TaskAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register ITodoRepository with TodoService
builder.Services.AddScoped<ITodoRepository, TodoService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//midlewares
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//startup.cs(ConfigureServices)
/*
 services.AddScoped(); // Only one instance for application
services.AddSingleton();// New object is created per request
services.AddTransient(); // always a new object is presented
 */

//from above we need 
/*
 * services.AddScoped<ITodoRepository,TodoService>();
 * 
to do dependency injection 
 */
