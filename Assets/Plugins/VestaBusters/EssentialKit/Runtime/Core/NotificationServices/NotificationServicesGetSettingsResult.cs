﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit
{
    /// <summary>
    /// This class contains the information retrieved when <see cref="NotificationServices.GetSettings(Callback{NotificationServicesGetSettingsResult})"/> is completed.
    /// </summary>
    public class NotificationServicesGetSettingsResult
    {
        #region Properties

        /// <summary>
        /// The runtime settings.
        /// </summary>
        public NotificationSettings Settings { get; private set; }

        #endregion

        #region Constructors

        internal NotificationServicesGetSettingsResult(NotificationSettings settings)
        {
            // Set properties
            Settings    = settings;
        }

        #endregion
    }
}