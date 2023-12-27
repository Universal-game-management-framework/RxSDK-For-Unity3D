using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum NetworkServicesDemoActionType
	{
		IsInternetActive,
		IsHostReachable,
		StartNotifier,
		StopNotifier,
        ResourcePage,
        IsNotifierActive,
	}

	public class NetworkServicesDemoAction : DemoActionBehaviour<NetworkServicesDemoActionType> 
	{}
}