namespace ISIvanti.Server.Dtos;

public class ManagedMachineValueDto
{
    public List<ManagedMachineDto>? Value { get; set; }
}

public class ManagedMachineDto
{
    public string? AssignedGroup { get; set; }
    public string? IpAddress { get; set; }
    public string? Name { get; set; }
}
