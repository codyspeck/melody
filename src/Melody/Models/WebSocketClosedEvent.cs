namespace Melody.Models;

public class WebSocketClosedEvent
{
    public string Reason { get; init; } = string.Empty;

    public int Code { get; init; }

    public bool ByRemote { get; init; }
}