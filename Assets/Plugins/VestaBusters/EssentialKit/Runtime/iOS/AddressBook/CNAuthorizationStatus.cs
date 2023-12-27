﻿#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.AddressBookCore.iOS
{
    internal enum CNAuthorizationStatus : long
    {
        CNAuthorizationStatusNotDetermined,

        CNAuthorizationStatusRestricted,

        CNAuthorizationStatusDenied,

        CNAuthorizationStatusAuthorized,
    }
}
#endif