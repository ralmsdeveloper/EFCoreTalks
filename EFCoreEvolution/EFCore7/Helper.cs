using EFCore7;


public static class Helper
{
	public static void RecreateDatabase()
	{
		using var db = new ExemploContext();

		db.Database.EnsureDeleted();
		db.Database.EnsureCreated(); 
	}

	public static void PopulateDatabase()
	{
		using var db = new ExemploContext();

		db.Blogs.Add(new() { Title = "ralms.io", Url = "http://ralms.io" });
		db.Blogs.Add(new() { Title = "ralms.net", Url = "ralms.net" });

		db.SaveChanges();
	}
}