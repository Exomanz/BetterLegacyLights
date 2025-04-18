using SiraUtil.Affinity;
using Zenject;

namespace BetterLegacyLights.AffinityPatches
{
    internal class BeatmapDataLoader_LoadBeatmapDataAsyncPatch : IAffinity
    {
        [Inject] private readonly BeatmapDataLoader _beatmapDataLoader;
        [Inject] private readonly PluginConfig _config;

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
