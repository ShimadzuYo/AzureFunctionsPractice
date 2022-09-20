using Microsoft.Extensions.Configuration;

namespace ConfigurationsApp;

public class Output
{
    public Output(IConfiguration huiConfiguration)
    {
        var name = huiConfiguration.GetSection("Section1").GetSection("Section2").GetSection("Name").Value;
        var age = huiConfiguration.GetSection("Section1").GetSection("Section2").GetSection("Age").Value;
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}