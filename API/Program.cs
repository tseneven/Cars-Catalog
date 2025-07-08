using API.Repositorys.Catalog;
using API.Repositorys.Auth;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddSingleton<IAuth_Repository, Auth_Repository>();
builder.Services.AddSingleton<ICatalog_Repository, Catalog_Repository>();


var app = builder.Build();


app.UseAuthorization();

app.MapControllers();

app.Run();
