using BetterLegacyLights.Installers;
using IPA;
using IPA.Config.Stores;
using SiraUtil.Zenject;
using IPAConfig = IPA.Config.Config;
using IPALogger = IPA.Logging.Logger;

namespace BetterLegacyLights
{
    [Plugin(RuntimeOptions.DynamicInit), NoEnableDisable]
    public class Plugin
    {
        [Init]
        public Plugin(IPALogger logger, IPAConfig config, Zenjector zenjector)
        {
            PluginConfig _config = config.Generated<PluginConfig>();
            zenjector.UseLogger(logger);
            zenjector.Install<BetterLegacyLightsAppInstaller>(Location.App);
        }
    }
}
