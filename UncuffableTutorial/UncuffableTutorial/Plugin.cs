namespace UncuffableTutorial
{
    using System;
    using Exiled.API.Features;

    /// <inheritdoc />
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <inheritdoc/>
        public override string Author { get; } = "Music";

        /// <inheritdoc/>
        public override string Name { get; } = "UncuffableTutorial";

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);

        /// <inheritdoc/>
        public override string Prefix { get; } = "UncuffableTutorial";

        /// <inheritdoc/>
        public override Version Version { get; } = new Version(1, 0, 0);
        

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers(this);
            Exiled.Events.Handlers.Player.Handcuffing += eventHandlers.OnCuffing;
            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Handcuffing -= eventHandlers.OnCuffing;
            eventHandlers = null;
            base.OnDisabled();
        }
    }
}