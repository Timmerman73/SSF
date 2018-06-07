using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Bolt
{
    public class Program
    {
        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
         
        private CommandHandler  _handler;

        public async Task StartAsync()
        {


            _client = new DiscordSocketClient();

            //  new  CommandHandler(_client);

            await _client.LoginAsync(TokenType.Bot, progress.env.BOT_TOKEN);

            await _client.StartAsync();

            _handler =  new CommandHandler(_client);

            await Task.Delay(-1);

        }

    }
}
