using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TaskTamer.DataLayer.Models;

public partial class TaskTamerContext : DbContext
{
    public TaskTamerContext()
    {
    }

    public TaskTamerContext(DbContextOptions<TaskTamerContext> options)
        : base(options)
    {
    }

    public static void EnsureDatabase()
    {
        using var context = new TaskTamerContext();
        context.Database.EnsureCreated();
    }

    [AllowNull]
    public virtual DbSet<Category> Categories { get; set; }

    [AllowNull]
    public virtual DbSet<Project> Projects { get; set; }

    [AllowNull]
    public virtual DbSet<TaskItem> TaskItems { get; set; }

    [AllowNull]
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=TaskTamer;Integrated Security=True;");
}
