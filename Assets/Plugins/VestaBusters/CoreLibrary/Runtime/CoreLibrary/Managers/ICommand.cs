﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
    public interface ICommand
    {
        #region Properties

        bool IsDone { get; }

        Error Error { get; }

        #endregion

        #region Methods

        void Execute();

        #endregion
    }
}