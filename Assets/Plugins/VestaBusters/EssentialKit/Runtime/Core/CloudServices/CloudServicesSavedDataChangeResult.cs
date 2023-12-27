using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.EssentialKit.CloudServicesCore;

namespace VestaBusters.EssentialKit
{
    /// <summary>
    /// This class contains the information related to <see cref="CloudServices.OnSavedDataChange"/> event.
    /// </summary>
    public class CloudServicesSavedDataChangeResult
    {
        #region Properties

        /// <summary>
        /// The reason causing local data change.
        /// </summary>
        public CloudSavedDataChangeReasonCode ChangeReason { get; private set; }

        /// <summary>
        /// An array of changed keys.
        /// </summary>
        public string[] ChangedKeys { get; private set; }

        #endregion

        #region Constructors

        internal CloudServicesSavedDataChangeResult(CloudSavedDataChangeReasonCode changeReason, string[] changedKeys)
        {
            // Set properties
            ChangeReason    = changeReason;
            ChangedKeys     = changedKeys;
        }

        #endregion
    }
}