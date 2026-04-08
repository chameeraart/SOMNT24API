using Microsoft.EntityFrameworkCore;
using SOMNT24BLL.Interfaces;
using SOMNT24BLL.Services;
using SOMNT24DAL.Data;
using SOMNT24DAL.Interfaces;
using SOMNT24DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// DB
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// DI
builder.Services.AddScoped<IReturnRepository, ReturnRepository>();
builder.Services.AddScoped<IReturnService, ReturnService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

builder.Services.AddControllers();
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
app.UseCors("AllowAnyOrigin");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
