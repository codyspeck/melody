using System.Net.WebSockets;
using System.Text;

namespace Melody;

public class LavalinkClient
{
    private const string Authorization = "youshallnotpass";

    private readonly HttpClient _httpClient = new();

    public async Task ConnectAsync()
    {
        var uri = new Uri("ws://localhost:2333/v4/websocket");
        
        using var webSocket = new ClientWebSocket();

        webSocket.Options.SetRequestHeader("Authorization", Authorization);
        webSocket.Options.SetRequestHeader("Client-Name", "client-name");
        webSocket.Options.SetRequestHeader("User-Id", "123");

        await webSocket.ConnectAsync(uri, CancellationToken.None);

        var buffer = new byte[1024];
        
        var result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);
        
        var response = Encoding.UTF8.GetString(buffer, 0, result.Count);
        
        Console.WriteLine(response);
    }
}
