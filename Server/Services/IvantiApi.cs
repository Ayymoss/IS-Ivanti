using System.Net;
using ISIvanti.Server.Dtos;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Utilities;
using IvantiToAdmins.Dtos;
using RestEase;

namespace ISIvanti.Server.Services;

public class IvantiApi
{
    private readonly IIvantiApi _api;
    private readonly ILogger _logger;

    public IvantiApi(IIvantiApi api, ILogger logger)
    {
        _api = api;
        _logger = logger;
    }

    public async Task<ConsoleVersionDto?> GetVersionAsync()
    {
        ConsoleVersionDto? data = null;
        try
        {
            var result = await _api.GetVersionAsync();
            data = await result.DeserializeHttpResponseContentAsync<ConsoleVersionDto>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "GetVersionAsync failed");
        }

        return data;
    }

    public async Task<ManagedMachineValueDto?> GetMachinesAsync(int count, int page, string nameSearch)
    {
        ManagedMachineValueDto? data = null;
        try
        {
            var result = await _api.GetMachinesAsync(count, page, nameSearch);
            data = await result.DeserializeHttpResponseContentAsync<ManagedMachineValueDto>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "GetMachinesAsync failed");
        }

        return data;
    }

    public async Task<AgentDetailValueDto?> GetAgentsAsync(int count, int page, string nameSearch)
    {
        AgentDetailValueDto? data = null;
        try
        {
            var result = await _api.GetAgentsAsync(count, page, nameSearch);
            data = await result.DeserializeHttpResponseContentAsync<AgentDetailValueDto>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "GetAgentsAsync failed");
        }

        return data;
    }

    public async Task<AgentPolicyValueDto?> GetPoliciesAsync(string agentId)
    {
        AgentPolicyValueDto? data = null;
        try
        {
            var result = await _api.GetPoliciesAsync(agentId);
            data = await result.DeserializeHttpResponseContentAsync<AgentPolicyValueDto>();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "GetPoliciesAsync failed");
        }

        return data;
    }

    public async Task<ExecutedTaskDto?> PostExecutePolicyAsync(ActionDto action)
    {
        ExecutedTaskDto? data = null;
        try
        {
            var result = await _api.PostExecutePolicyAsync(action.AgentId, action.TaskId);
            if (result.StatusCode is HttpStatusCode.OK)
            {

            }

            data = await result.DeserializeHttpResponseContentAsync<ExecutedTaskDto>();
        }
        catch (ApiException e)
        {
            data ??= new ExecutedTaskDto();
            data.FailCode = e.StatusCode.StatusCodeToString();
            _logger.LogError(e, "APIException -> PostExecutePolicyAsync failed");
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Generic -> PostExecutePolicyAsync failed");
        }

        return data;
    }

    public async Task<bool> PostExecuteCheckInAsync(ActionDto action)
    {
        var data = false;
        try
        {
            var result = await _api.PostExecuteCheckInAsync(action.AgentId);
            if (result.StatusCode is HttpStatusCode.OK)
            {

            }
        }
        catch (Exception e)
        {
            _logger.LogError(e, "PostExecuteCheckIn failed");
        }

        return data;
    }
}
