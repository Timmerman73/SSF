using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Bolt.Modules
{
    public class dm : ModuleBase<SocketCommandContext>
    {
        [Command("dm")]
        public async Task Dm(Discord.IUser user, [Remainder] string msg )
        {

            await user.SendMessageAsync(msg);
            await Context.Channel.SendMessageAsync("Successfully send a dm to `" + user.ToString() + "` With the message: `" + msg +"`");
        }
    }
}
