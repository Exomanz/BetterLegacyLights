using IPA.Config.Stores.Attributes;
using IPA.Config.Stores.Converters;

namespace BetterLegacyLights
{
    /// <summary>
    /// An abstraction of a set of lights. Contains properties for coloring, enabling, and adjusting the brightness of the light set as a whole.
    /// </summary>
    public class LightSet
    {
        public bool Enabled { get; set; }
        public string Name { get; }
        public int ColorMode { get; set; } // 1 = Left Saber; 5 = Right Saber
        public float Brightness { get; set; } 

        [UseConverter(typeof(EnumConverter<BasicBeatmapEventType>))]
        public BasicBeatmapEventType BeatmapEventType { get; set; }

        // Required for IPA.Config.Config.Generated<T>() to work
        public LightSet() { }

        internal LightSet(bool enabled, string name, int colorMode, float brightness, BasicBeatmapEventType eventType)
        {
            Enabled = enabled;
            Name = name;
            ColorMode = colorMode;
            Brightness = brightness > 1 ?
                1 :
                brightness;
            BeatmapEventType = eventType;
        }
    }
}
