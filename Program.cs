global using dotnet_rpg.Models;
global using dotnet_rpg.Services.CharacterService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 客製 Service
// 指定 實作 Service 的實體，可依照需求快速進行替換 
// AddScoped 方法: 包含 AddTransient、AddSingleton
builder.Services.AddScoped<ICharacterService, CharacterService>();


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
