using SiraUtil.Affinity;
using System.Collections.Generic;

namespace BetterLegacyLights.AffinityPatches
{
    internal class DefaultEnvironmentEventsFactory_InsertDefaultEventsPatch : IAffinity
    {
        private readonly PluginConfig _config;
        private readonly List<LightSet> _lightSetList;

        internal DefaultEnvironmentEventsFactory_InsertDefaultEventsPatch(PluginConfig config)
        {
            _lightSetList = new List<LightSet>()
            {
                config.LightSet_BackTop,
                config.LightSet_RingLights,
                config.LightSet_LeftLasers,
                config.LightSet_RightLasers,
                config.LightSet_BottomBackSide
            };

            _config = config;
        }

        /// <summary>
        /// Slightly modifies the DefaultEnvironmentEventsFactory to allow injection of custom light events at map start.
        /// </summary>
        [AffinityPrefix]
        [AffinityPatch(
            typeof(DefaultEnvironmentEventsFactory),
            nameof(DefaultEnvironmentEventsFactory.InsertDefaultEvents))]
        public bool PatchFactory(ref BeatmapData beatmapData)
        {
            foreach (LightSet lightSet in _lightSetList)
            {
                if (lightSet.Enabled)
                {
                    beatmapData.InsertBeatmapEventData(new BasicBeatmapEventData(
                        0f, lightSet.BeatmapEventType, lightSet.ColorMode, lightSet.Brightness));
                }
            }

            _config.DidAnySettingChange = false;
            return false;
        }
    }
}
