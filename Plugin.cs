using System;
using Exiled.API.Features;
using RueiHintsManager.Handlers;
using events = Exiled.Events.Handlers;

namespace RueiHintsManager
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;

        public override string Author => "Morkamo";
        public override string Name => "RueiHintsManager";
        public override string Prefix => Name;
        public override Version Version => new(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new(9, 1, 0);
        
        private WelcomeMessage _welcomeMessage = new();
        private ServerBadge _serverBadge = new();
        
        public override void OnEnabled()
        {
            Instance = this;
            _welcomeMessage = Config.WelcomeMessage;
            _serverBadge = Config.ServerBadge;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            _welcomeMessage = null;
            _serverBadge = null;
            Instance = null;
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            events.Player.Verified += _welcomeMessage.OnPlayerConnected;
            events.Player.Verified += _serverBadge.OnPlayerConnected;
        }

        private void UnregisterEvents()
        {
            events.Player.Verified -= _welcomeMessage.OnPlayerConnected;
            events.Player.Verified -= _serverBadge.OnPlayerConnected;
        }
    }
}