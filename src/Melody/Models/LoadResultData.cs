namespace Melody.Models;

public class LoadResultData
{
    public PlaylistInfo Info { get; init; } = null!;

    public List<TrackInfo> Tracks { get; init; } = [];
}