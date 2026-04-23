using Community.Api.Data;
using Community.Api.Endpoints;
using Community.Api.OpenApi;
using Community.Api.Security;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCorsConfiguration();
builder.Services.AddOpenApiConfiguration();

builder.Services.AddDbContext<DataContext>(x => 
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

var app = builder.Build();

app.UseCors("All");
app.UseHttpsRedirection();

app.MapOpenApiEndpoints();
app.MapCommunityEndpoints();

app.Run();
