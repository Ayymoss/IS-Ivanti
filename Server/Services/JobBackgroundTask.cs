using System.Net;
using Humanizer;
using ISIvanti.Server.Context;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Models;
using ISIvanti.Shared.Enums;
using ISIvanti.Shared.Utilities;

namespace ISIvanti.Server.Services;

public class JobBackgroundTask
{
    private readonly LocalDataContext _localContext;
    private readonly IAgentService _agentService;

    public JobBackgroundTask(LocalDataContext localContext, IAgentService agentService)
    {
        _localContext = localContext;
        _agentService = agentService;
    }

    public async Task ExecuteAsync(BackgroundJob jobParam)
    {
        try
        {
            var agentId = await _agentService.GetAgentIdAsync(jobParam.Action.MachineId);
            jobParam.Action.AgentId = BitConverter.ToString(agentId.AgentId).Replace("-", "");
            bool state;
            HttpStatusCode? stateResult;
            if (jobParam.Action.TaskId is "CHECKIN")
            {
                stateResult = await jobParam.Api.PostExecuteCheckInAsync(jobParam.Action);
                state = stateResult is HttpStatusCode.OK;
            }
            else
            {
                stateResult = await jobParam.Api.PostExecutePolicyAsync(jobParam.Action);
                state = stateResult is HttpStatusCode.OK;

            }

            jobParam.Job.State = state ? State.Completed : State.Failed;
            jobParam.Job.StateResult = stateResult ?? HttpStatusCode.InternalServerError;
            jobParam.Job.Completed = DateTime.UtcNow;
            _localContext.Jobs.Update(jobParam.Job);
            await _localContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine("Job Async Issue! {0}", e);
            jobParam.Job.State = State.Failed;
            _localContext.Jobs.Update(jobParam.Job);
            await _localContext.SaveChangesAsync();
        }
    }
}
