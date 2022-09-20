using System.Text.Json;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.Extensions.Options;

namespace API;

public class BackGroundService : BackgroundService
{
    private readonly PeriodicTimer _timer;
    private ILogger<IHostedService> _logger;
    private readonly QueueClient _queueClient;

    private readonly Message _message;
    
    public BackGroundService(
        QueueServiceClient queueServiceClient,
        ILogger<IHostedService> logger, 
        IOptions<QueueConfiguration> queueConfigurationOptions)
    {
        _message = queueConfigurationOptions.Value.MessageSample;
        _queueClient = queueServiceClient.GetQueueClient(queueConfigurationOptions.Value.QueueName);
        _queueClient.CreateIfNotExists();
        
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _timer = new PeriodicTimer(new TimeSpan(60000));
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (await _timer.WaitForNextTickAsync(stoppingToken))
        {
            var messageSerialzied = JsonSerializer.Serialize(_message);
            await _queueClient.SendMessageAsync(messageSerialzied, stoppingToken);
        }
    }


}

   