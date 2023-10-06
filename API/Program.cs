using System.Reflection;
using System.Text;
using API.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistence;
using API.Services;
using AspNetCoreRateLimit;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .Enrich.FromLogContext()
                    .CreateLogger();

// Add services to the container.
builder.Logging.AddSerilog(logger);
builder.Services.AddControllers();
builder.Services.ConfigureRateLimiting();

builder.Services.AddControllers(options =>
{
	options.RespectBrowserAcceptHeader = true;
	options.ReturnHttpNotAcceptable = true;
}).AddXmlSerializerFormatters();

// Add SQL Connection
builder.Services.AddDbContext<APIContext>(opts =>{
    string connection = builder.Configuration["ConnectionStrings:MainConnection"]?? throw new Exception("Error: Invalid Connection");
    opts.UseMySql(connection, ServerVersion.AutoDetect(connection));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureApiVersioning();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureRateLimiting();
builder.Services.ConfigureCors();

builder.Services.AddScoped<IAuthService, AuthService>();

var key = builder.Configuration.GetValue<string>("JWTSettings:Key");
var keyBytes = Encoding.ASCII.GetBytes(key);

builder.Services.AddAuthentication(config =>{
    config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(config => {
    config.RequireHttpsMetadata = false;
    config.SaveToken = true;
    config.TokenValidationParameters = new TokenValidationParameters {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(keyBytes),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseIpRateLimiting();

app.Run();