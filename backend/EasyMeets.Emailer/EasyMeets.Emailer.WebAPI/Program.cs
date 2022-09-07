using EasyMeets.Core.Common.DTO;
using EasyMeets.Emailer.WebAPI.Extensions;
using EasyMeets.Emailer.WebAPI.Services;
using EasyMeets.Emailer.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using sib_api_v3_sdk.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRabbitMqConnection(builder.Configuration);
builder.Services.AddEmailQueueListener(builder.Configuration);
builder.WebHost.UseUrls("http://*:5090");

var app = builder.Build();

Configuration.Default.ApiKey.Add("api-key", app.Configuration["SendingBlue_api_key"]);

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