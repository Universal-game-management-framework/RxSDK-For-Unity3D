#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.BillingServicesCore.iOS
{
    internal delegate void RequestForProductsNativeCallback(IntPtr productsPtr, int length, string error, ref NativeArray invalidProductIds);

    internal delegate void TransactionStateChangeNativeCallback(IntPtr transactionsPtr, int length);
    
    internal delegate void RestorePurchasesNativeCallback(IntPtr transactionsPtr, int length, string error);
}
#endif