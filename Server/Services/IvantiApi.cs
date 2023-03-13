using ISIvanti.Server.Interfaces.Ivanti;
using ISIvanti.Server.Utilities;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
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

    public async Task<ExecutedTaskDto?> PostExecutePolicyAsync(ActionDto action)
    {
        ExecutedTaskDto? data = null;
        try
        {
            var result = await _api.PostExecutePolicyAsync(action.AgentId, action.TaskId);
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
            return result.IsSuccessStatusCode;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "PostExecuteCheckIn failed");
        }

        return data;
    }
}
