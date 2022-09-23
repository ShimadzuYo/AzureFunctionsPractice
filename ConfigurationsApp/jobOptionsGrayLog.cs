using Microsoft.Extensions.Options;

namespace ConfigurationsApp;

public class jobOptionsGrayLog
{
    public bool Enabled { get; set; }
    public string Server { get; set; }
    public string Port { get; set; }
    public string LogLevel { get; set; }
    public string Facility { get; set; }
}