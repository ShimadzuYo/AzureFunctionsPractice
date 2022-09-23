namespace ConfigurationsApp;

public class ServiceConfigurationOptions
{
    public int MessagesToProcessPerIteration { get; set; }
    public string VisibilityTimeoutInSeconds { get; set; }
    public string MaxDequeueCount { get; set; }
    public int CreateJobQueueItemProcessorExecutionDelayInSeconds { get; set; }
    public Dictionary<string,string> Type { get; set; }
    public bool GetMessagesFromFwCreateJobQueue { get; set; }
}