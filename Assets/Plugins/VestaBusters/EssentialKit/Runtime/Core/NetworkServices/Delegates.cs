using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.NetworkServicesCore
{
    public delegate void InternetConnectivityChangeInternalCallback(bool isConnected);

    public delegate void HostReachabilityChangeInternalCallback(bool isReachable);
}