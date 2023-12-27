﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum RateMyAppDemoActionType
    {
        AskForReviewNow,
        ResourcePage
    }

    public class RateMyAppDemoAction : DemoActionBehaviour<RateMyAppDemoActionType> 
    {}
}