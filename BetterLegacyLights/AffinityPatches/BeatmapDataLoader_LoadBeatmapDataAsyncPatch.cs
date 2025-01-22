using SiraUtil.Affinity;

namespace BetterLegacyLights.AffinityPatches
{
    /// <summary>
    /// Force-disables the 'enableBeatmapDataCaching' flag in the LoadBeatmapDataAsync method.
    /// <br></br>This value is hardcoded to always be 'true' in the game.
    /// </summary>
    internal class BeatmapDataLoader_LoadBeatmapDataAsyncPatch : IAffinity
    {
        [AffinityPrefix]
        [AffinityPatch(
            typeof(BeatmapDataLoader),
            nameof(BeatmapDataLoader.LoadBeatmapDataAsync))]
        public bool DisableCaching(ref bool enableBeatmapDataCaching)
        {
            enableBeatmapDataCaching = false;
            return true;
        }
    }
}
