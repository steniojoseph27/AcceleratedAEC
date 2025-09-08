using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
    public class ContextHub : Hub
    {
        public Task JoinSession(string sessionId) => 
            Groups.AddToGroupAsync(Context.ConnectionId, sessionId);
    }
}