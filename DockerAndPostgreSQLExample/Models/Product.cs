namespace DockerAndPostgreSQLExample.Models;

public record Product
{
    public Guid Id { get; set; }

    //The required modifier is available beginning with C# 11 (Latest Verstion)
    public required string Name { get; set; }
}
