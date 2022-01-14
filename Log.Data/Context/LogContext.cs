using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Log.Data;

public class LogContext : DbContext
{
	public DbSet<Category> Category { get; set; }

	public DbSet<Place> Place { get; set; }

	public DbSet<Task> Task { get; set; }

	public DbSet<LogModel> Log { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder
			.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LogData")
			.LogTo(message => Debug.WriteLine(message));
	}
}