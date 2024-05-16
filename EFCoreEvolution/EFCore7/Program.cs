using EFCore7;
using Microsoft.EntityFrameworkCore;

var db = new ExemploContext();

db.Database.EnsureDeleted();
if (db.Database.EnsureCreated())
{ 
	db.Blogs.Add(new() { Title = "ralms.io", Url = "http://ralms.io" });
	db.Blogs.Add(new() { Title = "ralms.net", Url = "ralms.net" });

	db.SaveChanges();
}


#region EF.Property Interpretado Dinamicamente

var blogs = db.Blogs.OrderBy(p => EF.Property<object>(p, "Title")).ToList();

#endregion 

Console.ReadLine();