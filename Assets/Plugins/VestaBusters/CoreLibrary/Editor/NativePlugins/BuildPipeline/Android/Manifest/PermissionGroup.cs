using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary.Editor.NativePlugins.Build.Android
{
    public class PermissionGroup : Element
    {
        protected override string GetName()
        {
            return "permission-group";
        }
    }
}