namespace Melody.Tests;

public class Test
{
    [Fact]
    public async Task Test1()
    {
        var lavalink = new LavalinkClient();
        
        await lavalink.ConnectAsync();
    }
}
