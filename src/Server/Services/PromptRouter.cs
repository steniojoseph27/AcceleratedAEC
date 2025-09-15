using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.SignalR;
using Server.Hubs;

namespace Server.Services
{
    public class PromptRouter
    {
        private readonly IHubContext<ContextHub> _hub;
        public PromptRouter(IHubContext<ContextHub> hub) => _hub = hub;

        public Task RouteAsync(object mcpEnvelope)
        {
            var json = JsonSerializer.Serialize(mcpEnvelope);
            var sessionId = (string?)mcpEnvelope?.GetType().GetProperty("SessionId")?
                .GetValue(mcpEnvelope) ?? "default";
            return _hub.Clients.Group(sessionId).SendAsync("promptReceived", json);
        }
    }
}