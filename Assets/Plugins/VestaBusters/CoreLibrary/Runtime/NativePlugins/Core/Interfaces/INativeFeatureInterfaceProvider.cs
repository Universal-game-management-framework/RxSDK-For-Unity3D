using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins
{
    public interface INativeFeatureInterfaceProvider
    {
        INativeFeatureInterface CreateInterface(Type interfaceType, RuntimePlatform platform);
    }
}