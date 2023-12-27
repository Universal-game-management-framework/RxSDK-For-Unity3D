using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.NotificationServicesCore
{
    public delegate void RequestPermissionInternalCallback(NotificationPermissionStatus permissionStatus, Error error);

    public delegate void GetSettingsInternalCallback(NotificationSettingsInternal settings);

    public delegate void ScheduleNotificationInternalCallback(bool success, Error error);

    public delegate void GetNotificationsInternalCallback(INotification[] notifications, Error error);

    public delegate void NotificationReceivedInternalCallback(INotification notification);
    
    public delegate void RegisterForPushNotificationsInternalCallback(string deviceToken, Error error);
}