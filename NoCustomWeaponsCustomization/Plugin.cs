using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.CustomItems.API.Features;
using Exiled.API.Enums;

namespace NoCustomWeaponsCustomization
{
    public class NoCustomWeaponCustomization : Plugin<Config>
    {
        public static NoCustomWeaponCustomization Plugin { get; private set; }
        private EventHandlers _EventHandlers;
        public override string Name { get; } = "NCWC";
        public override string Author { get; } = "alone";
        public override string Prefix { get; } = "NCWC";
        public override PluginPriority Priority { get; } = PluginPriority.Default;
        public override Version Version { get; } = new Version(1, 0, 0);
        public override void OnEnabled()
        {
            Plugin = this;
            _EventHandlers = new EventHandlers();

            Exiled.Events.Handlers.Item.ChangingAttachments += _EventHandlers.ChangingAttacmhents;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Item.ChangingAttachments -= _EventHandlers.ChangingAttacmhents;

            Plugin = null;
            _EventHandlers = null;
            base.OnDisabled();
        }
    }
}
