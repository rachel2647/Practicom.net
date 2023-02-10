using MyProject.Context;
using MyProject.Repositories.Interfaces;
using MyProject.Services;

var builder = WebApplication.CreateBuilder(args);

string MyStr = "mystr";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyStr,
                      policy =>
                      {
                          policy.WithOrigins("*");
                      });
});

// Add services to the container.

builder.Services.AddServices();
builder.Services.AddDbContext<IContext, MyDBContext>();
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
app.UseCors(x => x
                 .AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
