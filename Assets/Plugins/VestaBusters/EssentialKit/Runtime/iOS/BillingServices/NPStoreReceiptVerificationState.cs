#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.BillingServicesCore.iOS
{
    internal enum NPStoreReceiptVerificationState : long
    {
        NPStoreReceiptVerificationStateNotChecked,

        NPStoreReceiptVerificationStateSuccess,

        NPStoreReceiptVerificationStateFailed
    }
}
#endif