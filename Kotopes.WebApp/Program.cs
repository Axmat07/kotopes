using ClassLibrary1;
using Kotopes.Application;
using Kotopes.Domain.Abstractions;
using Kotopes.Persistance;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(c =>
{
    c.UseNpgsql(builder.Configuration.GetConnectionString("db"));
});
builder.Services.AddScoped<DbContext, DataContext>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IShelterService, ShelterService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataBase = scope.ServiceProvider.GetRequiredService<DbContext>();
    dataBase.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();