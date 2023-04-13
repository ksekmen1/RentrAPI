using RentrAPI.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using RentrAPI;
using RentrAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowAll",
                              policy =>
                              {
                                  policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                              });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication().AddJwtBearer();

var optionsBuilder = new DbContextOptionsBuilder<UserDbContext>();
optionsBuilder.UseSqlServer(Secrets.ConnectionString);

builder.Services.AddSingleton(new RentrItemRepository());

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
