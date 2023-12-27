using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using VestaBusters.CoreLibrary.Editor;

namespace VestaBusters.CoreLibrary.Editor.NativePlugins.Build
{
    [CustomEditor(typeof(NativePluginsExporterObject))]
    public class NativePluginsExporterObjectEditor : CustomInspector
    { }
}