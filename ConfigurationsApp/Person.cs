using System.Collections;

namespace ConfigurationsApp;

public class Person : IEnumerable
{
    public int Id { get; set; }
    public bool IsDolboeb { get; set; }
    public string Name { get; set; }
    public List<string> Friends { get; set; } = new();
    public Dictionary<string, string> AdditionalInfo { get; set; }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}