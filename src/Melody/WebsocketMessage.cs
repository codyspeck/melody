using Melody.Models;

namespace Melody;

internal class WebsocketMessage
{
    public Op Op { get; init; } = Op.Unknown;

    public string GuildId { get; init; } = string.Empty;

    public PlayerState? State { get; init; }
}
