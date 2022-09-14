﻿using BasePlugin.Records;

namespace BasePlugin.Interfaces
{

    public interface IPlugin
    {
        public string Id { get; }
        public void Execute(PluginInput input);
        public bool IsEnabled { get { return true; } }
    }
}
