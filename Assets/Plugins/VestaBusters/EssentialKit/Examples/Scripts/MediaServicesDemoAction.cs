using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum MediaServicesDemoActionType
	{
		RequestGalleryAccess,
		GetGalleryAccessStatus,
        RequestCameraAccess,
        GetCameraAccessStatus,
        CanSelectImageFromGallery,
        SelectImageFromGallery,
        CanCaptureImageFromCamera,
        CaptureImageFromCamera,
        CanSaveImageToGallery,
		SaveImageToGallery,
        ResourcePage,
	}

	public class MediaServicesDemoAction : DemoActionBehaviour<MediaServicesDemoActionType> 
	{}
}