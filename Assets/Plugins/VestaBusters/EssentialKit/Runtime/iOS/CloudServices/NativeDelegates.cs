#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.CloudServicesCore.iOS
{
    internal delegate void UserChangeNativeCallback(ref CKAccountData accountData, string error);

    internal delegate void SavedDataChangeNativeCallback(int changeReason, ref NativeArray changedKeys);
}
#endif