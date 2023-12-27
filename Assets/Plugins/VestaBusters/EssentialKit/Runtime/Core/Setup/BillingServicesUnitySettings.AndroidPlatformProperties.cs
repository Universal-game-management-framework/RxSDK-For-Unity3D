﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit
{
    public partial class BillingServicesUnitySettings
    {
        [Serializable]
        public class AndroidPlatformProperties
        {
            #region Fields

            [SerializeField]
            [Tooltip("Public key provided by Google Play Services for in-app billing.")]
            private     string          m_publicKey;

            #endregion

            #region Properties

            public string PublicKey => PropertyHelper.GetValueOrDefault(m_publicKey);

            #endregion

            #region Constructors

            public AndroidPlatformProperties(string publicKey = null)
            {
                // set properties
                m_publicKey     = publicKey;
            }

            #endregion
        }
    }
}