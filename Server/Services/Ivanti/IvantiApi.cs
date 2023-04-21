using System.Net;
using ISIvanti.Server.Interfaces.Ivanti;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
using ISIvanti.Shared.Utilities;
using RestEase;

namespace ISIvanti.Server.Services.Ivanti;

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
            _logger.LogError(e, "GetActionRequiredComputers failed");
        }

        return data;
    }

    public async Task<HttpStatusCode?> PostExecutePolicyAsync(ActionDto action)
    {
        try
        {
            var result = await _api.PostExecutePolicyAsync(action.AgentId, action.TaskId);
            return result.StatusCode;
        }
        catch (ApiException e)
        {
            _logger.LogError(e, "APIException -> PostExecutePolicyAsync failed");
            return e.StatusCode;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Generic -> PostExecutePolicyAsync failed");
        }

        return null;
    }

    public async Task<HttpStatusCode?> PostExecuteCheckInAsync(ActionDto action)
    {
        try
        {
            var result = await _api.PostExecuteCheckInAsync(action.AgentId);
            return result.StatusCode;
        }
        catch (ApiException e)
        {
            _logger.LogError(e, "APIException -> PostExecutePolicyAsync failed");
            return e.StatusCode;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "PostExecuteCheckIn failed");
        }

        return null;
    }
}
