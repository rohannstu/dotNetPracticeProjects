var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var todos = new List<string>
{
    "Buy groceries",
    "Walk the dog",
    "Finish coding project"
}; 

app.MapGet("/todos", () =>
{
    return TypedResults.Ok(todos);
});

app.Run();

