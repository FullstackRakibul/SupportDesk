using Microsoft.EntityFrameworkCore;
using SupportDesk.Helper;
using SupportDesk.Model;
using SupportDesk.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// EmailSetting and Email Interface register 
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<EmailBoxService, EmailBoxService>();

// Dependency Injection 

builder.Services.AddDbContext<SupportDeskDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("defaultDB")));

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
