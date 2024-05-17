using EFCore8;
using Microsoft.EntityFrameworkCore;
using Model;


#region 1 - SQL Query - Modelo não mapeado (EF 8)
var db = new ExemploContext();
Helper.RecreateDatabase();
Helper.PopulateDatabase();

var blogs = db.Database.SqlQuery<BlogData>($"SELECT * FROM Blogs").ToArray();
foreach (var item in blogs)
{ 
	Console.WriteLine($"{item.Id} |{item.Title} | {item.Url}");
}
#endregion


 
Console.ReadLine();