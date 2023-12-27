#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.EssentialKit;

namespace VestaBusters.EssentialKit.NetworkServicesCore.iOS
{
    internal delegate void ReachabilityChangeNativeCallback(bool isReachable, NetworkStatus networkStatus);
}
#endif