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
    private readonly HttpClient _httpClient;

    public QueueTrigger(ILogger<QueueTrigger> logger,
        HttpClient httpClient)
    {
        _logger = logger;
        _httpClient = httpClient;
    }

    [FunctionName("QueueTrigger")]
    public async Task RunAsync([QueueTrigger("%QueueName%", Connection = "")] string myQueueItem, ILogger log)
    {
        var message = JsonSerializer.Deserialize<Message>(myQueueItem);
        
        log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        
    }
}