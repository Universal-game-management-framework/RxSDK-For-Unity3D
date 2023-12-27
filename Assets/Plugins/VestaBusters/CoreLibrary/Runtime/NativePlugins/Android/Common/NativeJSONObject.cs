#if UNITY_ANDROID
using System;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.CoreLibrary.NativePlugins.Android
{
    public class NativeJSONObject : NativeAndroidJavaObjectWrapper
    {
        public NativeJSONObject(AndroidJavaObject androidJavaObject) : base("org.json.JSONObject", androidJavaObject)
        {
        }

        public override string ToString()
        {
            return m_nativeObject.Call<string>("toString");
        }
    }
}
#endif