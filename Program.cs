using Microsoft.EntityFrameworkCore;
using QuasarWebAppAPI.EFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EF_DataContext>(
        o => o.UseNpgsql(builder.Configuration.GetConnectionString("DBConnection"))
    );

builder.Services.AddControllers();

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().
     AllowAnyHeader());
});

var app = builder.Build();

app.Urls.Add("http://{Local IP Address}:5024");

// Configure the HTTP request pipeline.

app.UseCors("AllowOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
