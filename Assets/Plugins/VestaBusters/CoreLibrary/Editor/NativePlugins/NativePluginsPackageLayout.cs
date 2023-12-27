using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary.Editor.NativePlugins
{
    public static class NativePluginsPackageLayout
    {
        public static string ExtrasPath { get { return "Assets/Plugins/VestaBusters/CoreLibrary"; } }

        public static string IosPluginPath { get { return ExtrasPath + "/Plugins/iOS"; } }
    }
}