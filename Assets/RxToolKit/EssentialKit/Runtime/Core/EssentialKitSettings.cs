using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RxToolKit.CoreLibrary;
using RxToolKit.CoreLibrary.NativePlugins;

namespace RX.EssentialKit
{
    public class EssentialKitDomain
    {
        public static string Default => "RxToolKit.CoreLibrary.EssentialKit";
    }

    public class EssentialKitSettings : SettingsObject
    {
        #region Static fields

        [ClearOnReload] private static EssentialKitSettings s_sharedInstance;

        [ClearOnReload] private static UnityPackageDefinition s_package;

        #endregion

        #region Static properties

        internal static UnityPackageDefinition Package => ObjectHelper.CreateInstanceIfNull(
            ref s_package,
            () =>
            {
                return new UnityPackageDefinition(name: "com.rxtoolkit.essentialkit",
                    displayName: "Essential Kit",
                    version: "1.1.0",
                    defaultInstallPath: $"Assets/Plugins/RxToolKit/EssentialKit",
                    dependencies: CoreLibrarySettings.Package);
            });

        public static string PackageName => Package.Name;

        public static string DisplayName => Package.DisplayName;

        public static string Version => Package.Version;

        public static string DefaultSettingsAssetName => "EssentialKitSettings";

        public static string DefaultSettingsAssetPath =>
            $"{Package.GetMutableResourcesPath()}/{DefaultSettingsAssetName}.asset";

        public static string PersistentDataPath => Package.PersistentDataPath;

        public static EssentialKitSettings Instance => GetSharedInstanceInternal();

        #endregion

        #region Static methods

        public static void SetSettings(EssentialKitSettings settings)
        {
            Assert.IsArgNotNull(settings, nameof(settings));

            // set properties
            s_sharedInstance = settings;
        }

        private static EssentialKitSettings GetSharedInstanceInternal(bool throwError = true)
        {
            if (null == s_sharedInstance)
            {
                // check whether we are accessing in edit or play mode
                var assetPath = DefaultSettingsAssetName;
                var settings = Resources.Load<EssentialKitSettings>(assetPath);
                if (throwError && (null == settings))
                {
                    throw Diagnostics.PluginNotConfiguredException("Essential Kit");
                }

                // store reference
                s_sharedInstance = settings;
            }

            return s_sharedInstance;
        }

        #endregion
    }
}