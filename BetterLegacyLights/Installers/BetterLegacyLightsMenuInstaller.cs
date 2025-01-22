using BetterLegacyLights.UI;
using Zenject;

namespace BetterLegacyLights.Installers
{
    internal class BetterLegacyLightsMenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<SettingsMenu>().AsSingle();
        }
    }
}
