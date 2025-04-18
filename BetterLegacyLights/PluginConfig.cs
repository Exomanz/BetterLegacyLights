using IPA.Config.Stores;
using IPA.Config.Stores.Attributes;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace BetterLegacyLights
{
    internal class PluginConfig
    {
        [Ignore] public bool DidAnySettingChange { get; set; } = false;

        public virtual LightSet LightSet_BackTop { get; set; } = new LightSet(
            true, 
            "BackTop", 
            1, 
            1,
            BasicBeatmapEventType.Event0);

        public virtual LightSet LightSet_RingLights { get; set; } = new LightSet(
            true,
            "RingLights",
            1,
            1,
            BasicBeatmapEventType.Event1);

        public virtual LightSet LightSet_LeftLasers { get; set; } = new LightSet(
            true,
            "LeftLasers",
            1,
            1,
            BasicBeatmapEventType.Event2);

        public virtual LightSet LightSet_RightLasers { get; set; } = new LightSet(
            true,
            "RightLasers",
            1,
            1,
            BasicBeatmapEventType.Event3);

        public virtual LightSet LightSet_BottomBackSide { get; set; } = new LightSet(
            true,
            "BottomBackSide",
            1,
            1,
            BasicBeatmapEventType.Event4);

        public virtual void Changed()
        {
            if (!DidAnySettingChange)
                DidAnySettingChange = true;
        }
    }
}
