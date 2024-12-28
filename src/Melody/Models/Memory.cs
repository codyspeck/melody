namespace Melody.Models;

public class Memory
{
    public int Free { get; init; }

    public int Used { get; init; }
    
    public int Allocated { get; init; }

    public int Reservable { get; init; }
}
