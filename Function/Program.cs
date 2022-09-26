using System.IO;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace Function;

public class Program
{
    public static IHostBuilder CreateHostBuilder(string[] args)
        => new HostBuilder()
            .ConfigureFunctionsWorkerDefaults()
            .ConfigureAppConfiguration(config => config
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("local.settings.json", true)
                .AddEnvironmentVariables())
            .AddInfrastructureServices();

    public static void Main(string [] args)
    {
        var host = CreateHostBuilder(args).Build();
    }

}