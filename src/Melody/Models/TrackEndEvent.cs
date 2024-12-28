namespace Melody.Models;

public class TrackEndEvent
{
    public TrackInfo Track { get; init; } = null!;

    public TrackEndReason Reason { get; init; }
}