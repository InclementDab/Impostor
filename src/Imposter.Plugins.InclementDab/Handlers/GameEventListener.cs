using System;
using System.Collections.Generic;
using System.Text;
using Impostor.Api.Events;

namespace Impostor.Plugins.InclementDab.Handlers
{
    class GameEventListener: IEventListener
    {
        [EventListener]
        public void OnGameCreated(IGameCreatedEvent e)
        {
            Console.WriteLine("Game > created");
        }
    }
}
