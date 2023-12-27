#if UNITY_ANDROID
using UnityEngine;
using System.Collections.Generic;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.WebViewCore.Android
{
    public enum NativeWebKitWebViewStyle
    {
        Default = 0,
        Popup = 1,
        ToolBar = 2
    }
    public class NativeWebKitWebViewStyleHelper
    {
        internal const string kClassName = "com.vestabusters.essentialkit.webview.WebKitWebViewStyle";

        public static AndroidJavaObject CreateWithValue(NativeWebKitWebViewStyle value)
        {
#if NATIVE_PLUGINS_DEBUG_ENABLED
            DebugLogger.Log("[NativeWebKitWebViewStyleHelper : NativeWebKitWebViewStyleHelper][Method(CreateWithValue) : NativeWebKitWebViewStyle]");
#endif
            AndroidJavaClass javaClass = new AndroidJavaClass(kClassName);
            AndroidJavaObject[] values = javaClass.CallStatic<AndroidJavaObject[]>("values");
            return values[(int)value];
        }

        public static NativeWebKitWebViewStyle ReadFromValue(AndroidJavaObject value)
        {
            return (NativeWebKitWebViewStyle)value.Call<int>("ordinal");
        }
    }
}
#endif