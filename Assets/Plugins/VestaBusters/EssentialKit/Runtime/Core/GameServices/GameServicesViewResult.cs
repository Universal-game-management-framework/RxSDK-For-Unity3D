﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit
{
    /// <summary>
    /// This class contains the information retrieved when game view is closed.
    /// </summary>
    public class GameServicesViewResult
    {
        #region Properties

        public GameServicesViewResultCode ResultCode { get; private set; }

        #endregion

        #region Constructors

        internal GameServicesViewResult(GameServicesViewResultCode resultCode)
        {
            // set properties
            ResultCode  = resultCode;
        }

        #endregion
    }
}