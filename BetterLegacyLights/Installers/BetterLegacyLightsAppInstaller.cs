using BetterLegacyLights.AffinityPatches;
using Zenject;

namespace BetterLegacyLights.Installers
{
    internal class BetterLegacyLightsAppInstaller : Installer
    {
        private readonly PluginConfig _config;

        public BetterLegacyLightsAppInstaller(PluginConfig config)
        {
            _config = config;
        }
        public override void InstallBindings()
        {
            Container.BindInstance(_config).AsCached();
            Container.BindInterfacesAndSelfTo<DefaultEnvironmentEventsFactory_InsertDefaultEventsPatch>().AsSingle();
            Container.BindInterfacesAndSelfTo<BeatmapDataLoader_LoadBeatmapDataAsyncPatch>().AsSingle();
        }
    }
}
