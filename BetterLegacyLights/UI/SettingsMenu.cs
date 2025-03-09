﻿using BeatSaberMarkupLanguage.GameplaySetup;
using BeatSaberMarkupLanguage.Attributes;
using System;
using Zenject;

namespace BetterLegacyLights.UI
{
    [ViewDefinition("BetterLegacyLights.UI.settingsMenu.bsml")]
    public class SettingsMenu : IInitializable, IDisposable
    {
        [Inject] private readonly PluginConfig pluginConfig;

        public void Initialize()
        {
            GameplaySetup.Instance.AddTab("BetterLegacyLights", "BetterLegacyLights.UI.settingsMenu.bsml", this);
        }

        public void Dispose()
        {
            GameplaySetup.Instance.RemoveTab("BetterLegacyLights");
        }

        #region LightSet Enabled Props
        [UIValue("ls-backtop-enabled")]
        public bool BackTopEnabled
        {
            get => pluginConfig.LightSet_BackTop.Enabled;
            set => pluginConfig.LightSet_BackTop.Enabled = value;
        }

        [UIValue("ls-ringlights-enabled")]
        public bool RingLightsEnabled
        {
            get => pluginConfig.LightSet_RingLights.Enabled;
            set => pluginConfig.LightSet_RingLights.Enabled = value;
        }

        [UIValue("ls-leftlasers-enabled")]
        public bool LeftLasersEnabled
        {
            get => pluginConfig.LightSet_LeftLasers.Enabled;
            set => pluginConfig.LightSet_LeftLasers.Enabled = value;
        }

        [UIValue("ls-rightlasers-enabled")]
        public bool RightLasersEnabled
        {
            get => pluginConfig.LightSet_RightLasers.Enabled;
            set => pluginConfig.LightSet_RightLasers.Enabled = value;
        }

        [UIValue("ls-bottombackside-enabled")]
        public bool BottomBackSideEnabled
        {
            get => pluginConfig.LightSet_BottomBackSide.Enabled;
            set => pluginConfig.LightSet_BottomBackSide.Enabled = value;
        }
        #endregion

        #region LightSet Color Props
        [UIValue("ls-backtop-color")]
        public bool BackTopColorSwitch
        {
            get => pluginConfig.LightSet_BackTop.ColorMode == 1;
            set => pluginConfig.LightSet_BackTop.ColorMode = value ? 1 : 5;
        }

        [UIValue("ls-ringlights-color")]
        public bool RingLightsColorSwitch
        {
            get => pluginConfig.LightSet_RingLights.ColorMode == 1;
            set => pluginConfig.LightSet_RingLights.ColorMode = value ? 1 : 5;
        }

        [UIValue("ls-leftlasers-color")]
        public bool LeftLasersColorSwitch
        {
            get => pluginConfig.LightSet_LeftLasers.ColorMode == 1;
            set => pluginConfig.LightSet_LeftLasers.ColorMode = value ? 1 : 5;
        }

        [UIValue("ls-rightlasers-color")]
        public bool RightLasersColorSwitch
        {
            get => pluginConfig.LightSet_RightLasers.ColorMode == 1;
            set => pluginConfig.LightSet_RightLasers.ColorMode = value ? 1 : 5;
        }

        [UIValue("ls-bottombackside-color")]
        public bool BottomBackSideColorSwitch
        {
            get => pluginConfig.LightSet_BottomBackSide.ColorMode == 1;
            set => pluginConfig.LightSet_BottomBackSide.ColorMode = value ? 1 : 5;
        }
        #endregion

        #region Lightset Brightness Props
        [UIValue("ls-backtop-brightness")]
        public float BackTopBrightness
        {
            get => pluginConfig.LightSet_BackTop.Brightness;
            set => pluginConfig.LightSet_BackTop.Brightness = value;
        }

        [UIValue("ls-ringlights-brightness")]
        public float RingLightsBrightness
        {
            get => pluginConfig.LightSet_RingLights.Brightness;
            set => pluginConfig.LightSet_RingLights.Brightness = value;
        }

        [UIValue("ls-leftlasers-brightness")]
        public float LeftLasersBrightness
        {
            get => pluginConfig.LightSet_LeftLasers.Brightness;
            set => pluginConfig.LightSet_LeftLasers.Brightness = value;
        }

        [UIValue("ls-rightlasers-brightness")]
        public float RightLasersBrightness
        {
            get => pluginConfig.LightSet_RightLasers.Brightness;
            set => pluginConfig.LightSet_RightLasers.Brightness = value;
        }

        [UIValue("ls-bottombackside-brightness")]
        public float BottomBackSideBrightness
        {
            get => pluginConfig.LightSet_BottomBackSide.Brightness;
            set => pluginConfig.LightSet_BottomBackSide.Brightness = value;
        }
        #endregion
    }
}
