namespace Melody.Models;

public class StatsOp
{
    public int Players { get; init; }

    public int PlayingPlayers { get; init; }

    public int Uptime { get; init; }
    
    public Memory Memory { get; init; }
    
    public Cpu Cpu { get; init; }
    
    public FrameStats FrameStats { get; init; }
}