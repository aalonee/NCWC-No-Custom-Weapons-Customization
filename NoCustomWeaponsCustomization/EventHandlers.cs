using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoCustomWeaponsCustomization
{
    public class EventHandlers
    {
        Config config = NoCustomWeaponCustomization.Plugin.Config;
        public void ChangingAttacmhents(ChangingAttachmentsEventArgs e)
        {
            if (CustomItem.TryGet(e.Firearm, out var item) && !config.WeaponsWhitelist.Contains(item.Id))
            {
                e.Player.ShowHint(config.Message);
                e.IsAllowed = false;
            }
        }
    }
}
