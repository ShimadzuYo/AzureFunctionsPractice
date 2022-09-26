using System.Threading.Channels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ConfigurationsApp;

public class SomeService
{
    private readonly GrayLogOptions _grayLogOptions;
    private readonly SqlServerOptions _sqlServerOptions;
    private readonly AzureOptions _azureOptions;
    private readonly ProviderApiOptions _providerApiOptions;
    private readonly ServiceConfigurationOptions _serviceConfigurationOptions;
    private readonly ResiliencePolicyOptions _resiliencePolicyOptions;
    private readonly BoxComOptions _boxComOptions;


    public SomeService(IOptions<GrayLogOptions> grayLogOptions, IOptions<SqlServerOptions> sqlOptions,
        IOptions<AzureOptions> azureOptions, IOptions<ProviderApiOptions> providerApiOptions,
        IOptions<ServiceConfigurationOptions> serviceConfigurationOptions,
        IOptions<ResiliencePolicyOptions> resiliencePolicyOptions,
        IOptions<BoxComOptions> boxComOptions)
    {
        _serviceConfigurationOptions = serviceConfigurationOptions.Value;
        _resiliencePolicyOptions = resiliencePolicyOptions.Value;
        _providerApiOptions = providerApiOptions.Value;
        _grayLogOptions = grayLogOptions.Value;
        _sqlServerOptions = sqlOptions.Value;
        _azureOptions = azureOptions.Value;
        _boxComOptions = boxComOptions.Value;
    }

    public void PrintConfigurations()
    {
        Console.WriteLine("Graylog configuration:");
        Console.WriteLine($"Server - {_grayLogOptions.Server}");
        Console.WriteLine($"Enabled - {_grayLogOptions.Enabled}");
        Console.WriteLine($"Facility - {_grayLogOptions.Facility}");
        Console.WriteLine($"Port - {_grayLogOptions.Port}");
        Console.WriteLine($"Log Level - {_grayLogOptions.LogLevel}");
        Console.WriteLine("Sql server configuration:");
        Console.WriteLine($"Connection string - {_sqlServerOptions.ConnectionString}");
        Console.WriteLine("Azure configuration:");
        Console.WriteLine($"{_azureOptions.EasylingQueueName}");
        Console.WriteLine($"{_azureOptions.NotificationsQueueName}");
        Console.WriteLine($"{_azureOptions.QueuesConnectionString}");
        Console.WriteLine($"{_azureOptions.BlobStorageConnectionString}");
        Console.WriteLine($"{_azureOptions.BlobStorageContainerName}");
        Console.WriteLine($"{_azureOptions.NewJobsQueueName}");
        Console.WriteLine("Provider Api options:");
        Console.WriteLine($"{_providerApiOptions.Token}");
        Console.WriteLine($"{_providerApiOptions.BaseUrl}");
        Console.WriteLine("Resilience policy options:");
        Console.WriteLine($"{_resiliencePolicyOptions.RequestTimeoutSeconds}");
        Console.WriteLine($"{_resiliencePolicyOptions.MedianFirstRetryDelaySeconds}");
        Console.WriteLine($"{_resiliencePolicyOptions.TransientApiErrorRetryCount}");
        Console.WriteLine("Providers with multiple folders:");
        if (_serviceConfigurationOptions.ProvidersWithSpecificFolders != null)
            foreach (var pair in _serviceConfigurationOptions.ProvidersWithSpecificFolders)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }
    }
}