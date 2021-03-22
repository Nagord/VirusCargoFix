using PulsarPluginLoader;

namespace VirusCargoFix
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0.1";

        public override string Author => "Dragon";

        public override string LongDescription => "Fixes issue where viruses get into cargo";

        public override string Name => "VirusCargoFix";

        public override string HarmonyIdentifier()
        {
            return "Dragon.VirusCargoFix";
        }
    }
}
