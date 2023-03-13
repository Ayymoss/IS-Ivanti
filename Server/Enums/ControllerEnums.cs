namespace ISIvanti.Server.Enums;

public abstract class ControllerEnums
{
    public enum ReturnState
    {
        Updated,
        Created,
        NotFound,
        BadRequest,
        Conflict,
        Accepted,
        Ok,
        Unauthorized,
        NoContent
    }
    
}
