using Finance.Api.Extentions;
using Finance.Api.Middleware;
using Finance.Application;
using Finance.Domain;
using Finance.Infastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<FinanceDbContext>(opt =>
        opt.UseNpgsql(config.GetConnectionString("PostgreSQL")));
builder.Logging.AddMyLogger(builder);

builder.Services.AddControllers();

builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddApplicationServices(config);

builder.Services.AddInfrastructureServices(config);
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
//app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
