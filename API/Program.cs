using API.Repositorys.Catalog;
using API.Repositorys.Auth;
using API.Repositorys.User;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddSingleton<IAuth_Repository, Auth_Repository>();
builder.Services.AddSingleton<ICatalog_Repository, Catalog_Repository>();
builder.Services.AddSingleton<IUser_Repository, User_Repository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
