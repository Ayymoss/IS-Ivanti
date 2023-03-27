namespace ISIvanti.Shared.Dtos.Ivanti;

public record ManagedMachineValueDto
{
    public List<ManagedMachineDto>? Value { get; set; }
}

public record ManagedMachineDto
{
    public string? AssignedGroup { get; set; }
    public string? IpAddress { get; set; }
    public string? Name { get; set; }
}
