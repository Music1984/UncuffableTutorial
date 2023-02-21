using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace UncuffableTutorial
{
    using Exiled.API.Features;

    /// <summary>
    /// General event handlers.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">The <see cref="Plugin{TConfig}"/> class reference.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ev"></param>
        public void OnCuffing(HandcuffingEventArgs ev)
        {
            if (ev.Target.Role == RoleTypeId.Tutorial)
            {
                ExplosiveGrenade grenade = (ExplosiveGrenade) Item.Create(ItemType.GrenadeHE);
                for (int i = 0; i < plugin.Config.Magnitude; i++)
                {w
                    grenade.FuseTime = 0.3f;
                    grenade.ScpDamageMultiplier = 0;
                    grenade.SpawnActive(ev.Player.Position, ev.Player);
                }
                ev.IsAllowed = false;
            }
        }
    }
}