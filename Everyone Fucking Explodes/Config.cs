using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace Everyone_Fucking_Explodes
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled? (should everyone fucking explode?)")]
        public bool IsEnabled { get; set; } = true;

        [Description("How much time after death the guy explodes? (in seconds)")]
        public int ExplodeTime { get; set; } = 1;
    }
}
