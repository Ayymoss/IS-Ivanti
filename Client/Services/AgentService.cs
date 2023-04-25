using ISIvanti.Client.Interfaces;
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
    private const string ApiHost = "https://isipatch.idealstandard.com:8123/api";
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
            var response = await _api.PostAgentPaginationAsync(pagination);
            var result = await response.DeserializeHttpResponseContentAsync<AgentContextDto>();
            return result ?? new AgentContextDto();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get agent pagination: {e.Message}");
        }

        return new AgentContextDto();
    }

    public async Task<string?> PostExecuteJobAsync(ActionDto action)
    {
        try
        {
            var response = await _api.PostExecuteJobAsync(action);
            if (!response.IsSuccessStatusCode) return null;
            return await response.Content.ReadAsStringAsync();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to post job execution: {e.Message}");
        }

        return null;
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

    public async Task<JobContextDto> PostJobPagination(PaginationDto pagination)
    {
        try
        {
            var response = await _api.PostJobPaginationAsync(pagination);
            var result = await response.DeserializeHttpResponseContentAsync<JobContextDto>();
            return result ?? new JobContextDto();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get job pagination: {e.Message}");
        }

        return new JobContextDto();
    }

    public async Task<List<string>?> PostExecuteJobsAsync(List<ActionDto> actions)
    {
        try
        {
            var response = await _api.PostExecuteJobsAsync(actions);
            if (!response.IsSuccessStatusCode) return null;
            return await response.DeserializeHttpResponseContentAsync<List<string>>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to post jobs execution: {e.Message}");
        }

        return null;
    }

    public async Task<List<string>?> GetAgentGroups()
    {
        try
        {
            var response = await _api.GetAgentGroups();
            if (!response.IsSuccessStatusCode) return null;
            return await response.DeserializeHttpResponseContentAsync<List<string>>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get policy groups: {e.Message}");
        }

        return null;
    }

    public async Task<IvantiStatisticsDto?> GetStatistics()
    {
        try
        {
            var response = await _api.GetStatistics();
            if (!response.IsSuccessStatusCode) return null;
            return await response.DeserializeHttpResponseContentAsync<IvantiStatisticsDto>();
        }
        catch (ApiException e)
        {
            Console.WriteLine($"API->Failed to get statistics: {e.Message}");
        }

        return null;
    }
}
