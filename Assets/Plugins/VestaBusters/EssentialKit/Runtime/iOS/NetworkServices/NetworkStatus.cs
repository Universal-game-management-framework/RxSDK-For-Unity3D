#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.NetworkServicesCore.iOS
{
    internal enum NetworkStatus : long
    {
        NotReachable = 0,

        ReachableViaWiFi,

        ReachableViaWWAN,
    }
}
#endif