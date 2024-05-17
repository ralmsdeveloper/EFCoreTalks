using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Model;

namespace EFCore8;

internal class ExemploContext : DbContext
{
	public DbSet<Blog> Blogs { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder
			.UseSqlServer("Server=localhost,1433;Database=EFCore8;User Id=sa;Password=@Ralms2024;MultipleActiveResultSets=true;Integrated Security=False;Encrypt=false;")
			.LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted }) 
			.EnableSensitiveDataLogging();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder
			.Entity<Blog>(p =>
			{
				p.HasIndex(b => b.Title).HasFillFactor(10);
                p.ToTable("Blogs", x => x.IsTemporal());
            });


		//modelBuilder.HasServiceTier("BusinessCritical");
		//modelBuilder.HasDatabaseMaxSize("2 GB");
		//modelBuilder.HasPerformanceLevelSql("ELASTIC_POOL ( name = myelasticpool )");
		//modelBuilder.HasPerformanceLevel("BC_Gen4_1");
	}

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        //configurationBuilder
        //	.Properties<string>()
        //	.AreUnicode(false)
        //	.HaveMaxLength(100);
    }
}
