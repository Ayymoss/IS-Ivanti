using System.Net.Http.Json;
using System.Text.Json;
using ISIvanti.Client.Interfaces.REST;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
using RestEase;

namespace ISIvanti.Client.Services;

public class AgentService
{
#if DEBUG
    private const string ApiHost = "/api";
#else
    private const string ApiHost = "/api";
#endif

    private readonly IAgentService _api;

    public AgentService()
    {
        _api = RestClient.For<IAgentService>(ApiHost);
    }

    public async Task<List<AgentDto>> PostAgentPagination(PaginationDto pagination)
    {
        try
        {
            var response = await _api.GetAgentPaginationAsync(pagination);
            if (!response.IsSuccessStatusCode) return new List<AgentDto>();
            var result = await response.Content.ReadFromJsonAsync<List<AgentDto>>();
            return result ?? new List<AgentDto>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"Failed to get agent pagination: {e.Message}");
        }

        return new List<AgentDto>();
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
            Console.WriteLine($"Failed to get agent count: {e.Message}");
        }

        return 0;
    }
    
    public async Task<ExecutedTaskDto?> PostExecutePolicyAsync(ActionDto action)
    {
        try
        {
            var response = await _api.PostExecutePolicyAsync(action);
            if (!response.IsSuccessStatusCode) return new ExecutedTaskDto();
            var result = await response.Content.ReadFromJsonAsync<ExecutedTaskDto>();
            return result ?? new ExecutedTaskDto();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"Failed to execute agent policy: {e.Message}");
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
            if (!response.IsSuccessStatusCode) return new List<AgentPolicyDto>();
            var result = await response.Content.ReadFromJsonAsync<List<AgentPolicyDto>>();
            return result ?? new List<AgentPolicyDto>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"Failed to execute agent checkin: {e.Message}");
        }

        return new List<AgentPolicyDto>();
    }
}
