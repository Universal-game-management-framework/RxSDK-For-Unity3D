using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum CloudServicesDemoActionType
	{
		GetBool,
		SetBool,
        GetLong,
        SetLong,
        GetDouble,
        SetDouble,
        GetString,
        SetString,
        GetByteArray,
        SetByteArray,
        Synchronize,
        RemoveKey,
		ResourcePage,
	}

	public class CloudServicesDemoAction : DemoActionBehaviour<CloudServicesDemoActionType> 
	{}
}