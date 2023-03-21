using ISIvanti.Server.Context;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Models;
using ISIvanti.Shared.Enums;

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
            var result = await jobParam.Api.PostExecuteCheckInAsync(jobParam.Action);
            jobParam.Job.State = result ? State.Completed : State.Failed;
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
