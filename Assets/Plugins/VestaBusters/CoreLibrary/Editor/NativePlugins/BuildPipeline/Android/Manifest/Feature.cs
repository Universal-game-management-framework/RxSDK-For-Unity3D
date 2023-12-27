using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary.Editor.NativePlugins.Build.Android
{
    public class Feature : Element
    {
        protected override string GetName()
        {
            return "uses-feature";
        }
    }
}
