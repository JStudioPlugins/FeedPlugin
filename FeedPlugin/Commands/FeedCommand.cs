using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;

namespace FeedPlugin.Commands
{
    class FeedCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "feed";

        public string Help => "Feeds you some yummy stuff";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "feed.main" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            player.Hunger = 0;
            player.Thirst = 0;
            UnturnedChat.Say(caller, "Would ya look at that! Some magical food came to you");
        }
    }
}
