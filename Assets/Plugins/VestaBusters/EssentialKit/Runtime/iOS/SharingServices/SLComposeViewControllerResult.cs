#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.SharingServicesCore.iOS
{
    internal enum SLComposeViewControllerResult : long
    {
        SLComposeViewControllerResultCancelled,

        SLComposeViewControllerResultDone,
    }
}
#endif