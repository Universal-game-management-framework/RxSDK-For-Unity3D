using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
    public class CoreLibrarySettings
    {
        #region Static fields

        private static UnityPackageDefinition s_package;

        #endregion

        #region Static properties

        public static UnityPackageDefinition Package => ObjectHelper.CreateInstanceIfNull(
            ref s_package,
            () =>
            {
                return new UnityPackageDefinition(
                    name: "com.vestabusters.corelibrary",
                    displayName: "Core Library",
                    version: "1.0.0",
                    defaultInstallPath: $"Assets/Plugins/VestaBusters/CoreLibrary");
            });

        public static string Name => Package.Name;

        public static string DisplayName => Package.DisplayName;

        public static string Version => Package.Version;

        #endregion
    }
}