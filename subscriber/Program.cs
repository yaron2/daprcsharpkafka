using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseCloudEvents();

app.MapGet("/", () => "Hello World!");

app.MapPost("/deposit", (Deposit deposit) =>
{
    Console.WriteLine(deposit.Id);
    return Results.Ok();
});

app.Run();

public record Deposit([property: JsonPropertyName("Id")] string Id);