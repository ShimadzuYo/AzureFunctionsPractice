using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Function;

public class ProviderApi
{
    private readonly HttpClient _httpClient;

    public ProviderApi(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Job> GetJob(string providerId, string jobId)
    {
        var httpResponseMessage = await _httpClient.GetAsync($"v2/providers{providerId}/jobs/{jobId}");
        var responseContentAsString = await httpResponseMessage.Content.ReadAsStringAsync();
        var job = JsonSerializer.Deserialize<Job>(responseContentAsString);
        return job;
    }
}