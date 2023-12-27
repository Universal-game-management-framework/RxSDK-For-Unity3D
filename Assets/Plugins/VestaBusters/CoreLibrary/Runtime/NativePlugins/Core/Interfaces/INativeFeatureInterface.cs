using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins
{
    public interface INativeFeatureInterface : INativeObject
    {
        #region Properties

        bool IsAvailable { get; }

        #endregion
    }
}