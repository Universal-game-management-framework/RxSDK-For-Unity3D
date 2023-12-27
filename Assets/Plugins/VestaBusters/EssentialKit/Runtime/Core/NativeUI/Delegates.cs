using System;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.NativeUICore
{
    public delegate void AlertButtonClickInternalCallback(int selectedButtonIndex);

    public delegate void DatePickerClosedInternalCallback(DateTime? selectedDate, Error error);
}