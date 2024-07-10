using DAL.Data;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Models;

//namespace OptixProject
//{
//public class Program
//{
//public static void Main(string[] args)
//{
var builder = WebApplication.CreateBuilder(args);
string myCors = "_myCors";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(op =>
{
    op.AddPolicy(myCors,
    builder => { builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod(); });
});
/////////////connectionString
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CustomerContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultDatabase")));
//builder.Services.AddTransient<ICustomer, CustomerData>();
builder.Services.AddScoped<ICustomer, CustomerData>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(myCors);
app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
//}
//}
//}