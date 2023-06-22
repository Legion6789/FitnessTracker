using BusinessEntities.EF;
using FitnessTracker;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddScoped<IDL, DL>();

ConnectionStringHolder.ConnectionString = Environment.GetEnvironmentVariable("SQLCONNSTR_FitnessTracker") ?? Environment.GetEnvironmentVariable("SQLCONNSTR_FitnessTracker", EnvironmentVariableTarget.Machine); //builder.Configuration.GetConnectionString("MSSQLConnection");

builder.Logging.AddEventLog(settings => { settings.SourceName = "FitnessTracker"; });

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
