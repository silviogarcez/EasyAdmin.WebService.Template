using EasyAdmin.Connection;
using EasyAdmin.Connection.Extensions;
using EasyAdmin.Deserializer.Extensions;
using EasyAdmin.Http;
using EasyAdmin.Http.Extensions;
using EasyAdmin.Connection.Enums;
using EasyAdmin.Caching.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var config = builder.Configuration;
var connectionString = config["ConnectionString"];

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCache();
builder.Services.AddSwaggerGen();
builder.Services.AddConnection(new ConnectionConfiguration(ConnectionType.SQL, connectionString));
builder.Services.AddDeserializer();
builder.Services.AddHttpService(new HttpServiceConfiguration() { UrlBase = ""});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
