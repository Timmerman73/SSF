using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Bolt.Modules
{
    public class Sff : ModuleBase<SocketCommandContext>
    {
        [Command("ssf")]
        public async Task Ssf()
        {

            await Context.Channel.SendMessageAsync("https://www.roblox.com/My/Groups.aspx?gid=3379746");


        }
    }
}
