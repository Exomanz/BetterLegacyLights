using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;

namespace BetterLegacyLights
{
    public class LightSet
    {
        public bool Enabled { get; set; }
        public string Name { get; }
        public int ColorMode { get; set; } // 1 = Left Saber; 5 = Right Saber

        [UseConverter(typeof(EnumConverter<BasicBeatmapEventType>))]
        public readonly BasicBeatmapEventType beatmapEventType;

        // Required for IPA.Config.Generated<T>() to work
        public LightSet() { }

        internal LightSet(bool enabled, string name, int colorMode, BasicBeatmapEventType eventType)
        {
            Enabled = enabled;
            Name = name;
            ColorMode = colorMode;
            beatmapEventType = eventType;
        }
    }
}
