using System.Security.Claims;
using ISIvanti.Server.Enums;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Services;
using ISIvanti.Shared.Dtos;
using ISIvanti.Shared.Dtos.Ivanti;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ISIvanti.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class AgentController : ControllerBase
{
    private readonly IAgentService _agentService;
    private readonly ApiClient _apiClient;

    public AgentController(IAgentService agentService, ApiClient apiClient)
    {
        _agentService = agentService;
        _apiClient = apiClient;
    }

    [HttpPost]
    public async Task<ActionResult<AgentContextDto>> GetInstancesAsync([FromBody] PaginationDto pagination)
    {
        return Ok(await _agentService.PaginationAsync(pagination));
    }

    [HttpGet]
    public async Task<ActionResult<int>> GetInstanceCountAsync()
    {
        return Ok(await _agentService.AgentsCountAsync());
    }

    [HttpGet("Policies")]
    public async Task<ActionResult<List<AgentPolicyDto>>> GetPoliciesAsync([FromQuery] int machineId)
    {
        return Ok(await _agentService.GetPoliciesAsync(machineId));
    }

    [HttpPost("ExecutePolicy")] // update these endpoints for new management system
    public async Task<ActionResult<ExecutedTaskDto>> PostExecutePolicyAsync([FromBody] ActionDto action)
    {
        var agentId = await _agentService.GetAgentIdAsync(action.MachineId);
        action.AgentId = BitConverter.ToString(agentId.AgentId).Replace("-", "");

        var adminIdentity = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        var api = _apiClient.GetIvantiApiAsync(Guid.Parse(adminIdentity));
        return Ok(await api.PostExecutePolicyAsync(action));
    }

    [HttpPost("ExecuteCheckIn")]
    public async Task<ActionResult<bool>> PostExecuteCheckInAsync([FromBody] ActionDto action)
    {
        var agentId = await _agentService.GetAgentIdAsync(action.MachineId);
        action.AgentId = BitConverter.ToString(agentId.AgentId).Replace("-", "");

        var adminIdentity = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        var api = _apiClient.GetIvantiApiAsync(Guid.Parse(adminIdentity));
        return Ok(await api.PostExecuteCheckInAsync(action));
    }
}
