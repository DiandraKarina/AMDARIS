using API.Filters;
using Application.Abstract;
using Application.Commands.Users;
using DataAccess;
using DataAccess.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Filters.Add(new ExceptionHandler()));
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped<IBlogRepository,BlogRepository>();
builder.Services.AddScoped<IBlogPostRepository, BlogPostRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddMediatR(typeof(CreateUserCommand));
builder.Services.AddAutoMapper(typeof(Program));

//builder.Services.Configure<MySettingsSection>(
//    builder.Configuration.GetSection(
//        nameof(MySettingsSection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseMyMiddleware();
//app.UseMyMiddleware2();

app.MapControllers();

app.Run();
app.Run();
