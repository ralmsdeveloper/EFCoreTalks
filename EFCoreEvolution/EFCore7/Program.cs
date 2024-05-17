using EFCore7;
using Microsoft.EntityFrameworkCore;
using Model;


//var db = new ExemploContext();
//db.Database.EnsureDeleted();
//return;

#region  1 - Configuração do modelo de pré-convenção (EF Core 6)
//var db = new ExemploContext();
//var script = db.Database.GenerateCreateScript();
//Console.WriteLine(script);
#endregion


#region 2 - Pacote de Migração  (EF Core 6)
/*
 * 1 - Melhor gerenciamento de migração principalmente para CI/CD
 * 2 - Único executável
 * 
 */
// dotnet ef migrations add Talks -v
// dotnet ef migrations bundle -v
#endregion


#region 3 - Modelos compilados  (EF Core 6)
// dotnet ef dbcontext optimize --namespace Ralms
// .UseModel(Ralms.ExemploContextModel.Instance)
#endregion


#region 4 - Tabelas Temporais (EF Core 6)
/*
 * 1 - Menos código para equipe Manter
 * 2 - Tudo é Auditado
 * 
 */
// p.ToTable("Blogs", x => x.IsTemporal());
//var db = new ExemploContext();
//Helper.RecreateDatabase();
//Helper.PopulateDatabase();

//UPDATE
//var blog = db.Blogs.Single(e => e.Title == "ralms.net");
//blog.Title = blog.Title + "- Teste";
//db.SaveChanges();

// REMOVE
//var blog = db.Blogs.Single(e => e.Title == "ralms.net");
//db.Remove(blog);
//db.SaveChanges();

// LIST
//var blogs = db
//	  .Blogs
//	  .ToList();

//Console.WriteLine($"Tabela Blog:");
//foreach (var item in blogs)
//{
//	Console.WriteLine($"{item.Title} | {item.Url}");
//}

//var blogsTemporal = db
//	  .Blogs
//	  .TemporalAll()
//	  .ToList();

//Console.WriteLine($"Tabela BlogHistory:");
//foreach (var item in blogs)
//{
//	var periodStartitem = db.Entry(item).Property<DateTime>("PeriodStart").CurrentValue;

//	Console.WriteLine($"{item.Title} | {item.Url} | {periodStartitem}");
//}

//var blogsWithSelect = db
//	  .Blogs
//	  .TemporalAll()
//	  .OrderByDescending(c => EF.Property<DateTime>(c, "PeriodStart"))
//	  .Select(
//		  c => new BlogHistory
//		  {
//			  Blog = c,
//			  PeriodStart = EF.Property<DateTime>(c, "PeriodStart"),
//			  PeriodEnd = EF.Property<DateTime>(c, "PeriodEnd")
//		  })
//	  .ToList();

//db.Blogs.Add(blogRestore);
//db.SaveChanges();
#endregion


#region 5 - Bulk Update And Delete  (EF Core 7)
//var db = new ExemploContext();
//Helper.RecreateDatabase();
//Helper.PopulateDatabase();

//await db.Blogs
//	.ExecuteUpdateAsync(
//		s => s.SetProperty(b => b.Title, b => b.Title + " - Novo"));

//await db.Blogs.ExecuteDeleteAsync();
#endregion


#region Outros
/*
db.Database.EnsureDeleted();
if (db.Database.EnsureCreated())
{ 
	db.Blogs.Add(new() { Title = "ralms.io", Url = "http://ralms.io" });
	db.Blogs.Add(new() { Title = "ralms.net", Url = "ralms.net" });

	db.SaveChanges();
}
*/
#endregion
Console.ReadLine();