namespace Melody.Models;

public class Track
{
    public string Title { get; init; }
    
    public string Uri { get; init; }
    
    public string? ArtworkUrl { get; init; }
    
    public string? Isrc { get; init; }
    
    public string sourceName { get; init; }
    
    public string identifier { get; init; }
    
    public string author { get; init; }
    
    public int length { get; init; }
    
    public int position { get; init; }
    
    public bool isSeekable { get; init; }
    
    public bool isStream { get; init; }
}
