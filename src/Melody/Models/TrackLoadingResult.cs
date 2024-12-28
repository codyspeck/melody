namespace Melody.Models;

public class TrackLoadingResult
{
    public LoadResultType LoadType { get; init; }

    public LoadResultData Data { get; init; } = null!;
}