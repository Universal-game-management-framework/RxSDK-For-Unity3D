using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.CoreLibrary.Editor.NativePlugins.DemoKit
{
    public class EditorDemoManager : MonoBehaviour
    {
        [UnityEditor.Callbacks.DidReloadScripts]
        private static void OnScriptsReloaded() 
        {
            if (EditorApplication.isPlaying)
            {
                DemoPanel  panel   = FindObjectOfType<DemoPanel>();
                if (panel != null)
                {
                    panel.Invoke(nameof(DemoPanel.Rebuild), 5f);
                }
            }
        }
    }
}