using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using plugin;
using System;
using System.Collections.Generic;

namespace Winagent.Settings
{
    [PluginAttribute(PluginName = "Settings")]
    public class EventLog : IOutputPlugin

    {
        int a = 0;

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "outputPlugins")]
        public List<OutputPlugin> OutputPlugins { get; set; }

        public event EventHandler<MessageEventArgs> MessageEvent;

        public void Execute(string jsonData, JObject settings)
        {
            
        }
    }
}
