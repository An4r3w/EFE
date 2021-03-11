using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using PlayerEvent = Exiled.Events.Handlers.Player;

namespace Everyone_Fucking_Explodes
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "An4r3w";

        public override string Name { get; } = "Everyone Fucking Explodes";

        public override string Prefix { get; } = "EFE";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(2, 8, 3);

		public override PluginPriority Priority { get; } = PluginPriority.Default;

		internal EventHandlers EventHandlers { get; set; }

		public override void OnEnabled()
		{
			Plugin.Singleton = this;
			this.EventHandlers = new EventHandlers();
			PlayerEvent.Dying += EventHandlers.OnPlayerDying;
		}

		public override void OnDisabled()
		{
			PlayerEvent.Dying -= EventHandlers.OnPlayerDying;
			this.EventHandlers = null;
		}

		public static Plugin Singleton;
	}
}
