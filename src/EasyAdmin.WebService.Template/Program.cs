using EasyAdmin.Authenticator;
using EasyAdmin.Authenticator.Extensions;
using EasyAdmin.Caching.Extensions;
using EasyAdmin.Connection;
using EasyAdmin.Connection.Enums;
using EasyAdmin.Connection.Extensions;
using EasyAdmin.Deserializer.Extensions;
using EasyAdmin.Http;
using EasyAdmin.Http.Extensions;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCache();
builder.Services.AddSwaggerGen();
builder.Services.AddConnection(new ConnectionConfiguration(ConnectionType.SQL, connectionString));
builder.Services.AddDeserializer();
builder.Services.AddHttpService(new HttpServiceConfiguration() { UrlBase = ""});
builder.Services.AddAuthenticationService(new AuthenticatorConfiguration() { ServiceName = "TemplateService", Version = "1.0.0" });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
