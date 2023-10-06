using System.Reflection;
using System.Text;
using API.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistence;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add SQL Connection
builder.Services.AddDbContext<APIContext>(opts =>{
    string connection = builder.Configuration["ConnectionStrings:MainConnection"]?? throw new Exception("Error: Invalid Connection");
    opts.UseMySql(connection, ServerVersion.AutoDetect(connection));
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
