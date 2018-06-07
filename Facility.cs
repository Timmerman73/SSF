using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Bolt.Modules
{
    public class scripter : ModuleBase<SocketCommandContext>
    {
        [Command("Facility")]
        public async Task Fchater()
        {

            await Context.Channel.SendMessageAsync("Link to the training facility: https://www.roblox.com/games/1364350220/S-S-F-Training-Facility-Vizsla ");

        }
    }
}
