using Microsoft.EntityFrameworkCore;
using Model;

namespace EFCore7;

internal class ExemploContext : DbContext
{
	public DbSet<Blog> Blogs { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder
			.UseSqlServer("Server=localhost,1433;Database=EFCore7;User Id=sa;Password=@Ralms2024;MultipleActiveResultSets=true;Integrated Security=False;Encrypt=false;")
			.LogTo(Console.WriteLine)
			.EnableSensitiveDataLogging();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{

		modelBuilder.Entity<Blog>(p =>
		{
			p.HasIndex(b => b.Title).HasFillFactor(10);
		});



		//modelBuilder.HasServiceTier("BusinessCritical");
		//modelBuilder.HasDatabaseMaxSize("2 GB");
		//modelBuilder.HasPerformanceLevelSql("ELASTIC_POOL ( name = myelasticpool )");
		//modelBuilder.HasPerformanceLevel("BC_Gen4_1");
	}
}
