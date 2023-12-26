using UnityEditor;
using RxToolKit.CoreLibrary.Editor;
using RxToolKit.CoreLibrary.NativePlugins;

namespace RX.EssentialKit.Editor
{
    [InitializeOnLoad]
    public class EssentialKitSettingsEditorUtility
    {
        #region Constants

        private const string kLocalPathInProjectSettings = "Project/RxToolKit/Essential Kit";

        #endregion

        #region Static fields

        private static EssentialKitSettings s_defaultSettings;

        #endregion

        #region Static properties

        public static EssentialKitSettings DefaultSettings
        {
            get
            {
                if (s_defaultSettings == null)
                {
                }

                return s_defaultSettings;
            }
        }

        public static bool SettingsExists
        {
            get
            {
                if (s_defaultSettings == null)
                {
                    s_defaultSettings = LoadDefaultSettingsObject(throwError: false);
                }

                return (s_defaultSettings != null);
            }
        }

        #endregion


        #region Static methods

        public static void OpenInProjectSettings()
        {
            if (!SettingsExists)
            {
                CreateDefaultSettingsObject();
            }

            Selection.activeObject = null;
            SettingsService.OpenProjectSettings(kLocalPathInProjectSettings);
        }

        #endregion

        #region Private static methods

        private static EssentialKitSettings CreateDefaultSettingsObject()
        {
            return AssetDatabaseUtility.CreateScriptableObject<EssentialKitSettings>(
                assetPath: EssentialKitSettings.DefaultSettingsAssetPath,
                onInit: (instance) => SetDefaultProperties(instance));
        }

        private static EssentialKitSettings LoadDefaultSettingsObject(bool throwError = true)
        {
            var throwErrorFunc = throwError
                ? () => Diagnostics.PluginNotConfiguredException()
                : (System.Func<System.Exception>)null;
            return AssetDatabaseUtility.LoadScriptableObject<EssentialKitSettings>(
                assetPath: EssentialKitSettings.DefaultSettingsAssetPath,
                onLoad: (instance) => SetDefaultProperties(instance),
                throwErrorFunc: throwErrorFunc);
        }

        private static void SetDefaultProperties(EssentialKitSettings settings)
        {
            // set properties
            // var     uiCollection        = settings.NativeUISettings.CustomUICollection;
            // if (uiCollection.RendererPrefab == null)
            // {
            //     uiCollection.RendererPrefab     = UnityUIEditorUtility.LoadRendererPrefab();
            // }
            // if (uiCollection.AlertDialogPrefab == null)
            // {
            //     uiCollection.AlertDialogPrefab  = UnityUIEditorUtility.LoadAlertDialogPrefab();
            // }
        }

        #endregion
    }
}