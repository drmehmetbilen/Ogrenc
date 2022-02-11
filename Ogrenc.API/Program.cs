using Microsoft.EntityFrameworkCore;
using Ogrenc.Business.Abstract;
using Ogrenc.Business.Concrete;
using Ogrenc.Business.ExtraClassesAbstract;
using Ogrenc.Business.ExtraClassesConcrete;
using Ogrenc.DataAccess;
using Ogrenc.DataAccess.Abstract;
using Ogrenc.DataAccess.Concrete;
using Ogrenc.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOgrenciService, OgrenciManager>();
builder.Services.AddScoped<IOgrenciRepository, OgrenciRepository>();

builder.Services.AddScoped<IGenericRepository<Bolum>, BolumRepository>();
builder.Services.AddScoped<IGenericRepository<OgretimElemani>, OgretimElemaniRepository>();


builder.Services.AddSingleton<IFunctions, Functions>();

builder.Services.AddDbContext<OgrenciDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("default")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

