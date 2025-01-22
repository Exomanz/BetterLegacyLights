using IPA.Config.Stores;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace BetterLegacyLights
{
    internal class PluginConfig
    {
        public virtual LightSet LightSet_BackTop { get; set; } = new LightSet(
            true, 
            "BackTop", 
            1, 
            BasicBeatmapEventType.Event0);

        public virtual LightSet LightSet_RingLights { get; set; } = new LightSet(
            true,
            "RingLights",
            1,
            BasicBeatmapEventType.Event1);

        public virtual LightSet LightSet_LeftLasers { get; set; } = new LightSet(
            true,
            "LeftLasers",
            1,
            BasicBeatmapEventType.Event2);

        public virtual LightSet LightSet_RightLasers { get; set; } = new LightSet(
            true,
            "RightLasers",
            1,
            BasicBeatmapEventType.Event3);

        public virtual LightSet LightSet_BottomBackSide { get; set; } = new LightSet(
            true,
            "BottomBackSide",
            1,
            BasicBeatmapEventType.Event4);
    }
}
