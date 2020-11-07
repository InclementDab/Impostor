using System;
using System.Threading.Tasks;
using Impostor.Api.Events.Managers;
using Impostor.Api.Plugins;
using Impostor.Plugins.InclementDab.Handlers;
using Microsoft.Extensions.Logging;


namespace Impostor.Plugins.InclementDab
{
    [ImpostorPlugin(
        package: "gg.impostor.inclementdab",
        name: "InclementDab Plugin",
        author: "InclementDab",
        version: "1.0.0")]
    public class InclementDabPlugin: PluginBase
    {
        private readonly ILogger<InclementDabPlugin> m_Logger;
        private readonly IEventManager m_EventManager;
        private IDisposable[] m_Cancel;

        public InclementDabPlugin(ILogger<InclementDabPlugin> logger, IEventManager event_manager)
        {
            m_Logger = logger;
            m_EventManager = event_manager;
        }

        public override ValueTask EnableAsync()
        {
            m_Logger.LogInformation("Enabling InclementDab Plugin");

            m_Cancel = new[]
            {
                m_EventManager.RegisterListener(new GameEventListener())
            };

            return default;
        }
    }
}
