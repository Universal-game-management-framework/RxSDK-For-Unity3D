using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.Editor;
using VestaBusters.EssentialKit;
using VestaBusters.CoreLibrary.NativePlugins;
using VestaBusters.CoreLibrary.Editor.NativePlugins.Build;

namespace VestaBusters.EssentialKit.Editor
{
    public static class EssentialKitBuildUtility 
    {
        #region Static methods

        public static bool IsReleaseBuild()
        {
            var     firstPackage    = ImplementationSchema.AddressBook.GetPackageForPlatform(RuntimePlatform.OSXEditor);
            return !(firstPackage == null || ReflectionUtility.FindAssemblyWithName(firstPackage.Assembly) == null);
        }

        #endregion
    }
}