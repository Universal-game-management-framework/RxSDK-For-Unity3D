using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit
{
    public interface IDeepLinkServicesDelegate
    {
        bool CanHandleCustomSchemeUrl(Uri link);

        bool CanHandleUniversalLink(Uri link);
    }
}