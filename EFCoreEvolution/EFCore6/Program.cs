using EFCore6;
using Microsoft.EntityFrameworkCore;

var db = new ExemploContext();

#region  1 - Configuração do modelo de pré-convenção
var script = db.Database.GenerateCreateScript();
Console.WriteLine(script);
#endregion


#region  2 - Pacote de Migração 
// dotnet ef migrations add Teste
#endregion

#region  99 - Outros
//db.Database.EnsureDeleted();
//if (db.Database.EnsureCreated())
//{ 
//	db.Blogs.Add(new() { Title = "ralms.io", Url = "http://ralms.io" });
//	db.Blogs.Add(new() { Title = "ralms.net", Url = "ralms.net" });

//	db.SaveChanges();
//}

//db = new ExemploContext();
//var blogs = db.Blogs.OrderBy(p => EF.Property<object>(p, "Title")).ToList();
#endregion
Console.ReadLine();