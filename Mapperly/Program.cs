// See https://aka.ms/new-console-template for more information

using Riok.Mapperly.Abstractions;

public class Car
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
}

public class CarDto
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
[Mapper]
public partial class Mapper {
    public partial CarDto Map(Car source, string name);
}