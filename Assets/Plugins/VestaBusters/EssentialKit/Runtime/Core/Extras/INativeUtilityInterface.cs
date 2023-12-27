using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.ExtrasCore
{
    public interface INativeUtilityInterface : INativeFeatureInterface
    {
        #region Methods

        void RequestStoreReview();

        void OpenAppStorePage(string applicationId);

        void OpenApplicationSettings();

        #endregion
    }
}