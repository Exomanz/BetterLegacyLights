using SiraUtil.Affinity;

namespace BetterLegacyLights.AffinityPatches
{
    internal class BeatmapDataLoader_LoadBeatmapDataAsyncPatch : IAffinity
    {
        /// <summary>
        /// Force-disables the <paramref name="enableBeatmapDataCaching"/> flag in the <see cref="BeatmapDataLoader.LoadBeatmapDataAsync(IBeatmapLevelData, BeatmapKey, float, bool, IEnvironmentInfo?, IEnvironmentInfo?, BeatmapLevelDataVersion, GameplayModifiers?, PlayerSpecificSettings?, bool)"/> method.
        /// <br/>Having this flag set to true in the game prevents this mod from updating its lights if the user plays the same level twice.
        /// <br/>This value is hardcoded to always be <see langword="true"/> in the game.
        /// </summary>a
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
