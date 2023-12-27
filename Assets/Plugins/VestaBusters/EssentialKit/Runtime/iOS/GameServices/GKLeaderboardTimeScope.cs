#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.GameServicesCore.iOS
{
    internal enum GKLeaderboardTimeScope : long
    {
        GKLeaderboardTimeScopeToday = 0,

        GKLeaderboardTimeScopeWeek,

        GKLeaderboardTimeScopeAllTime
    }
}
#endif