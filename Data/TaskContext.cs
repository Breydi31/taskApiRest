using Microsoft.EntityFrameworkCore;
using TaskModel = TaskApiRest.Models.Task;

namespace TaskApiRest.Data;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

    public DbSet<TaskModel> Tasks { get; set; }
    
}