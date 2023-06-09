﻿using System.Security.Claims;
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
    public async Task<ActionResult<AgentContextDto>> PostAgentPaginationAsync([FromBody] PaginationDto pagination)
    {
        return Ok(await _agentService.AgentPaginationAsync(pagination));
    }


    [HttpGet("Policies")]
    public async Task<ActionResult<List<AgentPolicyDto>>> GetPoliciesAsync([FromQuery] int machineId)
    {
        return Ok(await _agentService.GetPoliciesAsync(machineId));
    }

    [HttpPost("ExecuteJob")]
    public async Task<ActionResult<string>> ExecuteJobAsync([FromBody] ActionDto action)
    {
        var adminUserName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
        var adminIdentity = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        if (adminUserName is null || adminIdentity is null) return BadRequest("Admin user name not found.");
        var api = _apiClient.GetIvantiApiAsync(Guid.Parse(adminIdentity));
        if (api is null) return BadRequest("API client not found.");
        var guid = await _agentService.SetupExecuteJob(action, api, adminUserName);
        return Ok(guid?.ToString() ?? "Job failed to start");
    }

    [HttpPost("ExecuteJobs")]
    public async Task<ActionResult<List<string>>> ExecuteJobsAsync([FromBody] List<ActionDto> actions)
    {
        var adminUserName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
        var adminIdentity = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        if (adminUserName is null || adminIdentity is null) return BadRequest("Admin user name not found.");
        var api = _apiClient.GetIvantiApiAsync(Guid.Parse(adminIdentity));
        if (api is null) return BadRequest("API client not found.");

        var guids = new List<string>();
        foreach (var action in actions)
        {
            var guid = await _agentService.SetupExecuteJob(action, api, adminUserName);
            var guidString = guid.ToString();
            if (guidString is null) continue;
            guids.Add(guidString);
        }

        return Ok(guids);
    }

    [HttpPost("Jobs")]
    public async Task<ActionResult<JobContextDto>> PostJobPaginationAsync([FromBody] PaginationDto pagination)
    {
        return Accepted(await _agentService.JobPaginationAsync(pagination));
    }

    [HttpGet("PolicyGroups")]
    public async Task<ActionResult<List<string>>> GetAgentGroups()
    {
        return Ok(await _agentService.GetAgentGroups());
    }

    [HttpGet("Statistics")]
    public async Task<ActionResult<IvantiStatisticsDto>> GetStatistics()
    {
        var adminUserName = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
        return Ok(await _agentService.GetStatistics(adminUserName));
    }
}
