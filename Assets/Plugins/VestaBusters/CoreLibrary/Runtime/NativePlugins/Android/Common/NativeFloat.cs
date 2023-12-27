#if UNITY_ANDROID
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins.Android
{
    public class NativeFloat : NativeAndroidJavaObjectWrapper
    {
        public NativeFloat(AndroidJavaObject javaObject) : base("android.lang.Float", javaObject)
        {
        }

        public float GetFloatValue()
        {
            float value = m_nativeObject.Call<float>("floatValue");
            return value;
        }
    }
}
#endif