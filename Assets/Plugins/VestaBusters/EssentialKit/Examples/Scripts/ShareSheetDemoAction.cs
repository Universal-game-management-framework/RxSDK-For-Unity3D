using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum ShareSheetDemoActionType
	{
		New,
		AddText,
		AddScreenshot,
		AddImage,
		AddURL,
		Show,
		ResourcePage
	}

	public class ShareSheetDemoAction : DemoActionBehaviour<ShareSheetDemoActionType> 
	{}
}
