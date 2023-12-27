#if UNITY_IOS || UNITY_TVOS
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit.NativeUICore.iOS
{
    internal delegate void AlertActionSelectNativeCallback(IntPtr nativePtr, int selectedButtonIndex);
    internal delegate void DatePickerControllerNativeCallback(long selectedValue, IntPtr tagPtr);
}
#endif