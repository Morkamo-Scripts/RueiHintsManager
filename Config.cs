using Exiled.API.Interfaces;
using RueiHintsManager.Handlers;

namespace RueiHintsManager
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        
        public WelcomeMessage WelcomeMessage { get; set; } = new();
        public ServerBadge ServerBadge { get; set; } = new();
        public ProximityChatHint ProximityChatHint { get; set; } = new();
    }
}