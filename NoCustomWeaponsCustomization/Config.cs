using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace NoCustomWeaponsCustomization
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string Message { get; set; } = "<color=red>You can't edit attachments of custom weapons.";
        [Description("List of custom weapons IDs which you can edit")]
        public List<uint> WeaponsWhitelist { get; set; } = new List<uint>();
    }
}
