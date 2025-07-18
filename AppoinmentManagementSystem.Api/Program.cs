using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AppointmentManagementSystem.Infrastructure.Context;
using AppointmentManagementSystem.Application.Contracts;
using AppointmentManagementSystem.Infrastructure.Repository;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppointmentDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Local")));

builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
