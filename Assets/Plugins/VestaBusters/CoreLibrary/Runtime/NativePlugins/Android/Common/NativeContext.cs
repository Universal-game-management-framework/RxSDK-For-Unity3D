#if UNITY_ANDROID
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins.Android
{
    public class NativeContext : NativeAndroidJavaObjectWrapper
    {
        public NativeContext(AndroidJavaObject javaObject) : base("android.content.Context", javaObject)
        {
        }
    }
}
#endif