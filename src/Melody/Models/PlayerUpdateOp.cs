namespace Melody.Models;

public class PlayerUpdateOp
{
    public string GuildId { get; init; } = string.Empty;

    public PlayerState State { get; init; } = null!;
}
