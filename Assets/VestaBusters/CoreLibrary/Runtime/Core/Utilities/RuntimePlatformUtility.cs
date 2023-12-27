using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
    public static class RuntimePlatformUtility
    {
        public static bool IsEditor(this RuntimePlatform other)
        {
            return (other == RuntimePlatform.OSXEditor) ||
                   (other == RuntimePlatform.WindowsEditor) ||
                   (other == RuntimePlatform.OSXEditor);
        }
    }
}