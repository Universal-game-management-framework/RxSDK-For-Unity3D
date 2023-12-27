﻿#if UNITY_ANDROID
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins.Android
{
    public class NativeObject : NativeAndroidJavaObjectWrapper
    {
        public NativeObject(AndroidJavaObject javaObject) : base("android.lang.Object", javaObject)
        {
        }
    }
}
#endif