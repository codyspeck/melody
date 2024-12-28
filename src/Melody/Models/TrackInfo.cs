namespace Melody.Models;

public class TrackInfo
{
    public string Author { get; init; } = string.Empty;

    public string Identifier { get; init; } = string.Empty;

    public string SourceName { get; init; } = string.Empty;

    public string Title { get; init; } = string.Empty;

    public string Uri { get; init; } = string.Empty;
    
    public string? ArtworkUrl { get; init; }
    
    public string? Isrc { get; init; }

    public int Length { get; init; }
    
    public int Position { get; init; }
    
    public bool IsSeekable { get; init; }
    
    public bool IsStream { get; init; }
}
