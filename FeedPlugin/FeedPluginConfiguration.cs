using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Rocket.API;

namespace FeedPlugin
{
    public class FeedPluginConfiguration : IRocketPluginConfiguration
    {
        public bool IsFeedOnJoin { get; set; }

        public void LoadDefaults()
        {
            IsFeedOnJoin = true;
        }
    }
}
