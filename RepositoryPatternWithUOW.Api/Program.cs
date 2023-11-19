using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.api.Filters;
using RepositoryPatternWithUOW.DataService;
using RepositoryPatternWithUOW.Infrastructure;
using RepositoryPatternWithUOW.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region UnitOfWork , Services and DbContext

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Db"));
});

builder.Services.AddInfrastructureDependancies()
                .AddServiceDependancies()
                .AddAutoMapper();
#endregion

#region Filters

builder.Services.AddScoped<CheckUserExistsFilter>();
builder.Services.AddScoped<CheckBookEsistesFilter>();

#endregion



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
