using System.Net.Http.Json;
using System.Text.Json;
using ISIvanti.Client.Interfaces.REST;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Client.Services;

public class AgentService
{
#if DEBUG
    private const string ApiHost = "https://localhost:8123/api";
#else
    private const string ApiHost = "/api";
#endif

    private readonly IAgentService _api;

    public AgentService()
    {
        _api = RestClient.For<IAgentService>(ApiHost);
    }

    public async Task<AgentContextDto> PostAgentPagination(PaginationDto pagination)
    {
        try
        {
            var response = await _api.GetAgentPaginationAsync(pagination);
            var result = await response.DeserializeHttpResponseContentAsync<AgentContextDto>();
            return result ?? new AgentContextDto();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get agent pagination: {e.Message}");
        }

        return new AgentContextDto();
    }

    public async Task<int> GetAgentCount()
    {
        try
        {
            var response = await _api.GetAgentCountAsync();
            if (!response.IsSuccessStatusCode) return 0;
            var result = await response.Content.ReadAsStringAsync();
            return int.TryParse(result, out var count) ? count : 0;
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get agent count: {e.Message}");
        }

        return 0;
    }

    public async Task<ExecutedTaskDto?> PostExecutePolicyAsync(ActionDto action)
    {
        try
        {
            var response = await _api.PostExecutePolicyAsync(action);
            var result = await response.DeserializeHttpResponseContentAsync<ExecutedTaskDto>();
            return result ?? new ExecutedTaskDto();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to execute agent policy: {e.Message}");
        }

        return new ExecutedTaskDto();
    }

    public async Task<bool> PostExecuteCheckInAsync(ActionDto action)
    {
        try
        {
            var response = await _api.PostExecuteCheckInAsync(action);
            if (!response.IsSuccessStatusCode) return false;
            var result = await response.Content.ReadAsStringAsync();
            return bool.TryParse(result, out var state) && state;
        }
        catch (ApiException e)
        {
            Console.WriteLine($"Failed to execute agent checkin: {e.Message}");
        }

        return false;
    }

    public async Task<List<AgentPolicyDto>> GetPoliciesAsync(int machineId)
    {
        try
        {
            var response = await _api.GetPoliciesAsync(machineId);
            var result = await response.DeserializeHttpResponseContentAsync<List<AgentPolicyDto>>();
            return result ?? new List<AgentPolicyDto>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to execute agent checkin: {e.Message}");
        }

        return new List<AgentPolicyDto>();
    }
}
