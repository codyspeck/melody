namespace Melody.Models;

public class TrackExceptionEvent
{
    public TrackInfo Track { get; init; } = null!;
    
    public ExceptionInfo Exception { get; init; } = null!;
}

public class ExceptionInfo
{
    public string Cause { get; init; } = string.Empty;
    
    public string? Message { get; init; }

    public Severity Severity { get; init; }
}