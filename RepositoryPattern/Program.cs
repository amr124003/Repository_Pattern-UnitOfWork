using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.EF.Context;
using RepositoryPattern.EF.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbcontext>(Config =>
{
	Config.UseSqlServer(builder.Configuration.GetConnectionString("constr"),
		x => x.MigrationsAssembly(typeof(ApplicationDbcontext).Assembly.FullName));
});

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

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
