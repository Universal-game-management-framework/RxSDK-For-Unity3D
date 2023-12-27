#if UNITY_ANDROID
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins.Android
{
    public class NativeInteger : NativeAndroidJavaObjectWrapper
    {
        public NativeInteger(AndroidJavaObject javaObject) : base("android.lang.Integer", javaObject)
        {
        }

        public int GetIntValue()
        {
            int value = m_nativeObject.Call<int>("intValue");
            return value;
        }
    }
}
#endif