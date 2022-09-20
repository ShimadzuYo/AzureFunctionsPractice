﻿using System.Threading.Tasks;
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Function;

public static class QueueTrigger
{
    [FunctionName("QueueTrigger")]
    public static async Task RunAsync([QueueTrigger("%QueueName%", Connection = "")] string myQueueItem, ILogger log)
    {
        log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        
    }
}