using Riok.Mapperly.Abstractions;

var car = new Car
{
    Brand = "Audi",
    Model = "Q7"
};

var mapper = new Mapper();
var dto = mapper.Map(car, "foo");

Console.WriteLine($"{dto.Brand}, {dto.Model}, {dto.Name}");

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

