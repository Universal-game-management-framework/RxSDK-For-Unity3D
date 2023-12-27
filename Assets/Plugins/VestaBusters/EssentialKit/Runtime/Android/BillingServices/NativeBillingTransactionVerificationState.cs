#if UNITY_ANDROID
using UnityEngine;
using System.Collections.Generic;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.BillingServicesCore.Android
{
    public enum NativeBillingTransactionVerificationState
    {
        Unknown = 0,
        Success = 1,
        Failure = 2
    }
    public class NativeBillingTransactionVerificationStateHelper
    {
        internal const string kClassName = "com.vestabusters.essentialkit.billingservices.common.BillingTransactionVerificationState";

        public static AndroidJavaObject CreateWithValue(NativeBillingTransactionVerificationState value)
        {
#if NATIVE_PLUGINS_DEBUG_ENABLED
            DebugLogger.Log("[NativeBillingTransactionVerificationStateHelper : NativeBillingTransactionVerificationStateHelper][Method(CreateWithValue) : NativeBillingTransactionVerificationState]");
#endif
            AndroidJavaClass javaClass = new AndroidJavaClass(kClassName);
            AndroidJavaObject[] values = javaClass.CallStatic<AndroidJavaObject[]>("values");
            return values[(int)value];
        }

        public static NativeBillingTransactionVerificationState ReadFromValue(AndroidJavaObject value)
        {
            return (NativeBillingTransactionVerificationState)value.Call<int>("ordinal");
        }
    }
}
#endif