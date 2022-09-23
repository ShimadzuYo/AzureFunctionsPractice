namespace ConfigurationsApp;

public class ResiliencePolicyOptions
{
    public int TransientApiErrorRetryCount { get; set; }
    public int MedianFirstRetryDelaySeconds { get; set; }
    public int RequestTimeoutSeconds { get; set; }
}