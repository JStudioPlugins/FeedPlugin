using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;

namespace FeedPlugin
{
    public class FeedPlugin : RocketPlugin<FeedPluginConfiguration>
    {
        protected override void Load()
        {
            if (Configuration.Instance.IsFeedOnJoin == true)
            {
                U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            }
            Logger.Log("FeedPlugin On!");
        }

        private void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            if (player.HasPermission("feed.main"))
            {
                player.Hunger = 0;
                player.Thirst = 0;
            }
            else
            {
                Logger.Log("The player who has joined does not have feed.main permissions!", ConsoleColor.White);
            }
        }

        protected override void Unload()
        {
            Logger.Log("FeedPlugin Off!");
        }
    }
}
