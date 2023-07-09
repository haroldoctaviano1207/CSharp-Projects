using Microsoft.AspNetCore.SignalR;

namespace SignalRIntro.API;
public sealed class ChatHub: Hub<IChatClient>
{
    public override async Task OnConnectedAsync()
    {
        await Clients.All.ReceivedMessage($"{Context.ConnectionId} has joined.");
    }

    public async Task SendMessage(string message)
    {
        await Clients.All.ReceivedMessage($"{Context.ConnectionId}: {message}.");
    }
}
    