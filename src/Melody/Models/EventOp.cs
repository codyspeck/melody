namespace Melody.Models;

public class EventOp
{
    public string GuildId { get; init; } = string.Empty;

    public EventOpType Type { get; init; }
    
    public enum EventOpType
    {
        TrackStartEvent,
        TrackEndEvent,
        TrackExceptionEvent,
        TrackStuckEvent,
        WebSocketClosedEvent
    }
}
