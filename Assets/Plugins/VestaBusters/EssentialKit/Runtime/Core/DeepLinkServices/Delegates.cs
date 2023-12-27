using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.DeepLinkServicesCore
{
    public delegate void DynamicLinkOpenInternalCallback(string url);

    public delegate bool CanHandleDynamicLinkInternal(string url);
}