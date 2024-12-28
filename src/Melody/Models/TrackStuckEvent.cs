namespace Melody.Models;

public class TrackStuckEvent
{
    public int ThresholdMs { get; init; }

    public TrackInfo Track { get; init; } = null!;
}