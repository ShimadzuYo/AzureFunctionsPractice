namespace ConfigurationsApp;

public class JobConfig
{
    public Dictionary<string, string> GraylogSettings { get; set; }
    public string ConnectionString { get; set; }
    public Dictionary<string, string> ServiceConfiguration { get; set; }
    public Dictionary<string, string> ResiliencePolicy { get; set; }
    public Dictionary<string, string> ProviderApiConfiguration { get; set; }
    public Dictionary<string, string> AzureConfiguration { get; set; }
    public Dictionary<string, string> BoxComConfiguration { get; set; }

    public JobConfig()
    {
        
    }
    
}