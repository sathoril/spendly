using Domain.Entities;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(options =>
    options.AddDocumentTransformer((document, context, cancellationToken) =>
        {
            document.Info.Version = "v1";
            document.Info.Title = "Spendly API";
            document.Info.Description = "OpenAPI documentation for Spendly.";
            document.Info.Contact = new OpenApiContact
            {
                Email = "bruno.feabreu@proton.me",
                Name = "Bruno Fernando Corrêa de Abreu",
                Url = new Uri("https://github.com/sathoril/spendly")
            };
            return Task.CompletedTask;
        }
    )
)
.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options
            .WithTitle("Spendly")
            .WithSidebar(true);
    });
    app.MapControllers();
}

app.UseHttpsRedirection();

app.Run();