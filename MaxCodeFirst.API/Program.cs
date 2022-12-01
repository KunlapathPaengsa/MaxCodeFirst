using MaxCodeFirst.DALs.Repositories.Commands;
using MaxCodeFirst.DALs.Repositories.Commons;
using MaxCodeFirst.Models.Context;
using MaxCodeFirst.Models.TablesAndEntities;
using MaxCodeFirst.Service.Commands;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Install Microsoft.EntityFrameworkCore.InMemory
//builder.Services.AddDbContext<LocalDbContext>(opt =>
//opt.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LocalDB;"));

//builder.Services.AddDbContext<LocalDbContext>(option=>option.Options.on);
//builder.Services.AddMvc();
//builder.Services.AddScoped<IStudentCommandRepository,StudentCommandRepository>();


var app = builder.Build();


// Configure the HTTP request pipeline.if (app.Environment.IsDevelopment()){}
app.UseSwagger();
app.UseSwaggerUI();
//app.UseSwaggerUI(x =>
//{
//    x.SwaggerEndpoint(" / swagger/v1.1.0/swagger.json", "Max .NET core API V1");
//    x.RoutePrefix = string.Empty;
//});



app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
