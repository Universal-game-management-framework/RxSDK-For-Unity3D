using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace VestaBusters.EssentialKit.Editor
{
    public static class EssentialKitMenuManager
    {
        #region Contants

        private const string sMenuItemPath = "Window/VestaBusters/Essential Kit";

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