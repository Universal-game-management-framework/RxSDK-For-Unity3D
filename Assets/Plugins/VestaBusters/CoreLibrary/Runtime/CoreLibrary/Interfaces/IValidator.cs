﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
    public interface IValidator
    {
        #region Methods

        /// <summary>
        /// Validate this instance.
        /// </summary>
        /// <returns>The validation result.</returns>
        ValidationResult Validate();

        #endregion
    }
}