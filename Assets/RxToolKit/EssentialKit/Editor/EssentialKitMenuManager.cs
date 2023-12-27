using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace RX.EssentialKit.Editor
{
    public static class EssentialKitMenuManager
    {
        #region Contants

        private const string sMenuItemPath = "Window/RxToolKit/Essential Kit";

        #endregion

        #region Menu items

        [MenuItem(sMenuItemPath + "/Open Settings")]
        public static void OpenSettings()
        {
            EssentialKitSettingsEditorUtility.OpenInProjectSettings();
        }

        [MenuItem(sMenuItemPath + "/Uninstall")]
        public static void Uninstall()
        {
        }

        #endregion
    }
}