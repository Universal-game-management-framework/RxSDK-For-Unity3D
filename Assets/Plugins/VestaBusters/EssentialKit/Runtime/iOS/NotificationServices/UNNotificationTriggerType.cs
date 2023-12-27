#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.NotificationServicesCore.iOS
{
    internal enum UNNotificationTriggerType : long
    {
        UNNotificationTriggerTypeUnknown,

        UNNotificationTriggerTypePushNotification,

        UNNotificationTriggerTypeCalendar,

        UNNotificationTriggerTypeTimeInterval,

        UNNotificationTriggerTypeLocation,
    }
}
#endif