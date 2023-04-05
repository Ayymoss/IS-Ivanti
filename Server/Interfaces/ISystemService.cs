using ISIvanti.Shared.Dtos;

namespace ISIvanti.Server.Interfaces;

public interface ISystemService
{
    Task<SystemMessageDto?> GetSystemMessage();
}
