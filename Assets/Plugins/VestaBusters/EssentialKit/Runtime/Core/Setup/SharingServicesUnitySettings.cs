using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit
{
    [Serializable]
    public partial class SharingServicesUnitySettings : SettingsPropertyGroup
    {
        #region Constructors

        public SharingServicesUnitySettings(bool isEnabled = true)
            : base(isEnabled: isEnabled, name: NativeFeatureType.kSharingServices)
        { }

        #endregion
    }
}