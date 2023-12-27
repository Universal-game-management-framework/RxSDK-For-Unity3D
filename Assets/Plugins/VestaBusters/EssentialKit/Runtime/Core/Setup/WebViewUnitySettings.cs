using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit
{
    [Serializable]
    public partial class WebViewUnitySettings : SettingsPropertyGroup
    {
        #region Fields

        [SerializeField]
        [Tooltip("Android specific settings.")]
        private     AndroidPlatformProperties   m_androidProperties;

        #endregion

        #region Properties

        public AndroidPlatformProperties AndroidProperties => m_androidProperties;

        #endregion

        #region Constructors

        public WebViewUnitySettings(bool isEnabled = true, AndroidPlatformProperties androidProperties = null) 
            : base(isEnabled: isEnabled, name: NativeFeatureType.kWebView)
        {
            m_androidProperties = androidProperties ?? new AndroidPlatformProperties();
        }

        #endregion
    }
}