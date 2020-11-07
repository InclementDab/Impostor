using System;
using System.Collections.Generic;
using System.Text;
using Impostor.Api.Events;
using Impostor.Api.Events.Player;

namespace Impostor.Plugins.InclementDab.Handlers
{
    class GameEventListener: IEventListener
    {
        [EventListener]
        public void OnGameCreated(IGameCreatedEvent e)
        {
            Console.WriteLine("Game > created");
        }

        [EventListener]
        public void OnPlayerChat(IPlayerChatEvent e)
        {
            Console.WriteLine($"Chat message {e.Message}");
            
            if (e.Message == "suicide")
            {

            }

            if (e.Message == "blind")
            {
                e.ClientPlayer.Game.Options.CrewLightMod = 0;
            }
            
        }
    }
}
