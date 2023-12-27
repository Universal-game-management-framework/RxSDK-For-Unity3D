﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit
{
    /// <summary>
    /// This class contains the information retrieved when <see cref="GameServices.LoadLeaderboards(EventCallback{GameServicesLoadLeaderboardsResult})"/> operation is completed.
    /// </summary>
    public class GameServicesLoadLeaderboardsResult
    {
        #region Properties

        /// <summary>
        /// An array of registered leaderboards.
        /// </summary>
        public ILeaderboard[] Leaderboards { get; private set; }

        #endregion

        #region Constructors

        internal GameServicesLoadLeaderboardsResult(ILeaderboard[] leaderboards)
        {
            // set properties
            Leaderboards     = leaderboards;
        }

        #endregion
    }
}