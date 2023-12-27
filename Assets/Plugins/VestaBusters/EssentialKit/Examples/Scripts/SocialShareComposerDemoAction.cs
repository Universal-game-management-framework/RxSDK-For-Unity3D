using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
    public enum SocialShareComposerDemoActionType
	{
		IsComposerAvailable,
		New,
		SetText,
		AddScreenshot,
		AddImage,
		AddURL,
		Show,
		ResourcePage
	}

	public class SocialShareComposerDemoAction : DemoActionBehaviour<SocialShareComposerDemoActionType> 
	{}
}