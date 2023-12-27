#if UNITY_ANDROID
using System;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.CloudServicesCore.Android
{
    internal static class Converter
    {
        internal static CloudSavedDataChangeReasonCode from(NativeExternalChangeReason reason)
        {
            switch(reason)
            {
                case NativeExternalChangeReason.InitialSync:
                    return CloudSavedDataChangeReasonCode.InitialSyncChange;
                case NativeExternalChangeReason.ServerSync:
                    return CloudSavedDataChangeReasonCode.ServerChange;
                case NativeExternalChangeReason.UserChange:
                    return CloudSavedDataChangeReasonCode.AccountChange;
                default:
                    throw VBException.SwitchCaseNotImplemented(reason);
            }
        }
    }
}
#endif
