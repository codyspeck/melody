namespace Melody.Models;

public class ReadyOp
{
    public string SessionId { get; init; } = string.Empty;

    public bool Resumed { get; init; }
}
