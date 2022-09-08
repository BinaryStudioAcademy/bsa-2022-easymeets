using EasyMeets.Core.Common.DTO;
using EasyMeets.Emailer.WebAPI.Extensions;
using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterCustomServices(builder.Configuration);
builder.WebHost.UseUrls("http://*:5090");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/send", async ([FromBody] EmailDto model, IEmailService emailService) =>
{
    return await emailService.SendEmailAsync(model.Recipient, model.Body, model.Subject);
})
.WithName("SendEmail");

app.Run();