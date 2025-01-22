using SiraUtil.Affinity;
using System.Collections.Generic;

namespace BetterLegacyLights.AffinityPatches
{
    /// <summary>
    /// Slightly modifies the DefaultEnvironmentEventsFactory to allow injection of custom light events at map start.
    /// </summary>
    internal class DefaultEnvironmentEventsFactory_InsertDefaultEventsPatch : IAffinity
    {
        private readonly PluginConfig _config;
        private readonly List<LightSet> lightSetList;

        internal DefaultEnvironmentEventsFactory_InsertDefaultEventsPatch(PluginConfig config)
        {
            lightSetList = new List<LightSet>()
            {
                config.LightSet_BackTop,
                config.LightSet_RingLights,
                config.LightSet_LeftLasers,
                config.LightSet_RightLasers,
                config.LightSet_BottomBackSide
            };

            _config = config;
        }

        [AffinityPrefix]
        [AffinityPatch(
            typeof(DefaultEnvironmentEventsFactory),
            nameof(DefaultEnvironmentEventsFactory.InsertDefaultEvents))]
        protected bool PatchFactory(ref BeatmapData beatmapData)
        {
            foreach (LightSet lightSet in lightSetList)
            {
                if (lightSet.Enabled)
                {
                    beatmapData.InsertBeatmapEventData(new BasicBeatmapEventData(
                        0f, lightSet.beatmapEventType, lightSet.ColorMode, 1f));
                }
            }

            return false;
        }
    }
}
