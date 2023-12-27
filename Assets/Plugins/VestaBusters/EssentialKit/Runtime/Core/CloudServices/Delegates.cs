﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.CloudServicesCore
{
    public delegate void UserChangeInternalCallback(CloudUser user, Error error);

    public delegate void SavedDataChangeInternalCallback(CloudSavedDataChangeReasonCode changeReason, string[] changedKeys);

    public delegate void SynchronizeInternalCallback(bool success, Error error);
}