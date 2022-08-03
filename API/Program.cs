using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.ConfigurePersistenceServices(builder.Configuration);
//builder.Services.AddDbContext<DataContext>(opt =>
//{
//    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(Application.Activities.List.Handler).Assembly);

builder.Services.AddCors(opt =>
    opt.AddPolicy("CorsPolicy", policy => 
    {
        policy.AllowAnyMethod()
       .AllowAnyHeader()
       .WithOrigins("http://localhost:3000");
    })       
); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
