using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Text.Json;
using API;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Function;

public class QueueTrigger
{
    private readonly ILogger<QueueTrigger> _logger;
    private readonly ProviderApi _providerApi;

    public QueueTrigger(ILogger<QueueTrigger> logger, ProviderApi providerApi)
    {
        _logger = logger;
        _providerApi = providerApi;
    }

    [FunctionName("QueueTrigger")]
    public async Task RunAsync([QueueTrigger("%QueueName%", Connection = "")] string myQueueItem, ILogger log)
    {
        var message = JsonSerializer.Deserialize<Message>(myQueueItem);
        
        log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        var job = await _providerApi.GetJob(message.ProviderId, message.JobId);
        Console.WriteLine(job.JobId, job.ProviderId);

    }
}