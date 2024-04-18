using Microsoft.EntityFrameworkCore;
using PruebaCovisian;
using PruebaCovisian.Repositories;
using PruebaCovisian.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AlquilerContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepository, DataBaseRepository>();
builder.Services.AddScoped<IAlquilerService, AlquilerService>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors(app => app.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();

app.Run();
