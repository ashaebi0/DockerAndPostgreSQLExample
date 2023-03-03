using DockerAndPostgreSQLExample.Models;

var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/product", () =>
{
    var id = new Product() { Name = "" };


});

app.Run();

