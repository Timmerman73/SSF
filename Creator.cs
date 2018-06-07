using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Bolt.Modules
{
    public class Creator : ModuleBase<SocketCommandContext>
    {
        [Command("Creator")]
        public async Task CreatorTim()
        {

            await Context.Channel.SendMessageAsync("The creator of this bot is `Tim#3678` Roblox profile: https://www.roblox.com/users/174585579/profile ");
        }
    }
}
