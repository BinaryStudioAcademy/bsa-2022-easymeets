using EasyMeets.Emailer.WebAPI.DTO;
using EasyMeets.Emailer.WebAPI.Services;
using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IEmailService, EmailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/send", async ([FromBody] EmailDto model) =>
{
    var service = app.Services.GetRequiredService<IEmailService>();
    var result = await service.SendEmail(model.Recipient, model.Body, model.Subject);
    return result;
})
.WithName("SendEmail");

app.Run();