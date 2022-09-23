namespace ConfigurationsApp;

public class AzureOptions
{
    public string NewJobsQueueName { get; set; }
    public string BlobStorageConnectionString { get; set; }
    public string BlobStorageContainerName { get; set; }
    public string QueuesConnectionString { get; set; }
    public string NotificationsQueueName { get; set; }
    public string EasylingQueueName { get; set; }
}