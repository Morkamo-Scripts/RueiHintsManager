using System;
using Exiled.API.Features;

namespace RueiHintsManager
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;

        public override string Author => "Morkamo";
        public override string Name => "RueiHintsManager";
        public override string Prefix => Name;
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(9, 1, 0);

        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            base.OnDisabled();
        }
    }
}