using Melody.Models;

namespace Melody;

internal class WebsocketMessage
{
    public string GuildId { get; init; } = string.Empty;
    
    public Op Op { get; init; }

    public PlayerState? State { get; init; }
}
