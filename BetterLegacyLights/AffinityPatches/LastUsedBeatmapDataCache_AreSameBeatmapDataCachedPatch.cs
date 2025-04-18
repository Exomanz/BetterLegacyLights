using SiraUtil.Affinity;
using Zenject;

namespace BetterLegacyLights.AffinityPatches
{
    internal class LastUsedBeatmapDataCache_AreSameBeatmapDataCachedPatch : IAffinity
    {
        [Inject] private readonly BeatmapDataLoader _beatmapDataLoader;
        [Inject] private readonly PluginConfig _config;

        /// <summary>
        /// Adds a new check which determines whether the settings have been changed between sessions.
        /// <br/>The cache will be re-used if no settings have been changed, otherwise it will reload the map and insert new events.
        /// </summary>
        /// <returns></returns>
        [AffinityPrefix]
        [AffinityPatch(
            typeof(LastUsedBeatmapDataCache),
            nameof(LastUsedBeatmapDataCache.AreSameBeatmapDataCached))]
        public bool InvalidateCache()
        {
            return !_config.DidAnySettingChange;
        }
    }
}
