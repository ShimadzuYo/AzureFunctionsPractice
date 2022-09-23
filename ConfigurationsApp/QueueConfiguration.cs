namespace ConfigurationsApp;

public class QueueConfiguration
{
    public const string ConfigSectionName = "QueueConfiguration";
    public string ConnectionString { get; set; }
    public string QueueName { get; set; }
}