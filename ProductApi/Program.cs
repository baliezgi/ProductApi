using ProductApi.Controllers;
using ProductApi.Filters;
using ProductApi.Mapping;
using ProductApi.Models.Products;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IProductRepository, ProductRepository>(); //dependency injection
builder.Services.AddScoped<IProductService, ProductService>();//dependency injection
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ActionFilter>();//dependency injection
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();
//Example of middleware
//app.Use(async (context, next) =>
//{
//   Console.WriteLine("Middleware 1 request");
//    await next();
//    Console.WriteLine("Middleware 1 response");
//});

//app.Run(context =>
//{
//    Console.WriteLine("Middleware 2");
//    return Task.CompletedTask;
//});





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
