#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.NotificationServicesCore.iOS
{
    internal enum UNShowPreviewsSetting : long
    {
        UNShowPreviewsSettingAlways = 0,
    
        UNShowPreviewsSettingWhenAuthenticated,
        
        UNShowPreviewsSettingNever,
    }
}
#endif