using EFTEST.Data;
using EFTEST.Repositorys.Intrfases;
using EFTEST.Repositorys.SSMSImplementatins;
using EFTEST.Services.Implementations;
using EFTEST.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICuerrencyRepository ,CurrencyRepository>();
builder.Services.AddScoped<ICurrencyServics,CurrencyServices>();

builder.Services.AddScoped<ILanguageRepository ,LanguagesRepository>();
builder.Services.AddScoped<ILanuageServices, LanguageServices>();

builder.Services.AddScoped<IJoinRepository ,JoinRepository>();
builder.Services.AddScoped<IJoinServise, JoinServises>();


builder.Services.AddScoped<IBookRepository ,BookRepository>();
builder.Services.AddScoped<IBookServices, BookServices>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
