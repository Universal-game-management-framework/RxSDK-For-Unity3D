﻿#if UNITY_IOS || UNITY_TVOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.NativeUICore.iOS
{
    internal static class DatePickerUtility
    {
        #region Converter methods

        public static UIDatePickerMode ConvertToUIDatePickerMode(DatePickerMode mode)
        {
            switch (mode)
            {
                case DatePickerMode.Date:
                    return UIDatePickerMode.UIDatePickerModeDate;

                case DatePickerMode.Time:
                    return UIDatePickerMode.UIDatePickerModeTime;

                case DatePickerMode.DateAndTime:
                    return UIDatePickerMode.UIDatePickerModeDateAndTime;

                default:
                    throw VBException.SwitchCaseNotImplemented(mode);
            }
        }

        #endregion
    }
}
#endif