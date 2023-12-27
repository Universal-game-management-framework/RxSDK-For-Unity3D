using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum UtilitiesDemoActionType
	{
		OpenAppStorePage,
        OpenCustomAppStorePage,
		ResourcePage,
        OpenApplicationSettings,
	}

	public class UtilitiesDemoAction : DemoActionBehaviour<UtilitiesDemoActionType> 
	{}
}