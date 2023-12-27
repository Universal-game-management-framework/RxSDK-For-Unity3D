using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.NativeUICore
{
    public interface INativeUIInterface : INativeFeatureInterface
    {
        #region Methods

        INativeAlertDialogInterface CreateAlertDialog(AlertDialogStyle style);

        INativeDatePickerInterface CreateDatePicker(DatePickerMode mode);

        #endregion
    }
}