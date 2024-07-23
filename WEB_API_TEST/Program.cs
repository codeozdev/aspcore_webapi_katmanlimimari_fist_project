using CoreLayer.Repositories;
using CoreLayer.Service;
using CoreLayer.UnitOfWorks;
using DataLayer;
using DataLayer.Repositories;
using DataLayer.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Mapping;
using ServiceLayer.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


// GENERICS SERVIC
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

// CUSTOM SERVISLER
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();



// Mapping
builder.Services.AddAutoMapper(typeof(MapProfile));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

