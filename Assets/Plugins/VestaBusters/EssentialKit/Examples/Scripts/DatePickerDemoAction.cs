using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum DatePickerDemoActionType
	{
		New,
		Show,
		ResourcePage,
	}

	public class DatePickerDemoAction : DemoActionBehaviour<DatePickerDemoActionType> 
	{}
}