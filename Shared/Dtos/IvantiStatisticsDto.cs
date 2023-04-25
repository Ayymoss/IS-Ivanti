namespace ISIvanti.Shared.Dtos;

public record IvantiStatisticsDto
{
    public int MachinesUnderHealth { get; set; }
    public int TotalAdminJobsSubmitted { get; set; }
    public int UserAdminJobsSubmitted { get; set; }
}
