using PaymentCore.Api.Controllers;
using PaymentCore.Api.Routes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PaymentController>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/heath", () => "API UP");
app.PaymentRoutes();

app.UseHttpsRedirection();

app.Logger.LogInformation(
    "Application starting up in {Environment} mode",
    app.Environment.EnvironmentName
);
app.Run();
