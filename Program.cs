using Microsoft.EntityFrameworkCore;
using TaskApiRest.Data;

var builder = WebApplication.CreateBuilder(args);

// Conexión BD
builder.Services.AddDbContext<TaskContext>(options =>
    options.UseSqlite("Data Source=tareas.db"));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<TaskContext>();
    db.Database.EnsureCreated();
}

app.Run();
