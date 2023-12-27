﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.CoreLibrary.NativePlugins
{
    public interface INativeFeatureUsagePermissionHandler
    {
        void ShowPrepermissionDialog(string permissionType, Callback onAllowCallback, Callback onDenyCallback);
    }
}