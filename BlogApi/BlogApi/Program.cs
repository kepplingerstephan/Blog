using BlogApi.Endpoints;
using Core;
using Core.Interfaces;
using Core.Mapper;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using userApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BlogDbContext>(options => 
	options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDbConnection")!));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITopicService, TopicService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.ConfigureBlogEndpoints();
app.ConfigureTopicEndpoints();
app.ConfigureUserEndpoints();

app.UseHttpsRedirection();

app.Run();