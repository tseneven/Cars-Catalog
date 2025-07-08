using API.Repositorys.Auth;
using API.Repositorys.Catalog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IAuth_Repository, Auth_Repository>();
builder.Services.AddSingleton<ICatalog_Repositorycs, Catalog_Repositorycs>();

var app = builder.Build();


//app.UseSwagger();
//app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
