﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.GameServicesCore
{
    public delegate void LoadLeaderboardsInternalCallback(ILeaderboard[] leaderboards, Error error);

    public delegate void LoadAchievementDescriptionsInternalCallback(IAchievementDescription[] achievementDescriptions, Error error);

    public delegate void LoadAchievementsInternalCallback(IAchievement[] achievements, Error error);

    public delegate void ReportAchievementProgressInternalCallback(bool success, Error error);

    public delegate void LocalPlayerAuthChangeInternalCallback(ILocalPlayer localPlayer, Error error);

    public delegate void LoadPlayersInternalCallback(IPlayer[] players, Error error);

    public delegate void LoadScoresInternalCallback(IScore[] scores, Error error);

    public delegate void ReportScoreInternalCallback(bool success, Error error);

    public delegate void ViewClosedInternalCallback(Error error);

    public delegate void LoadServerCredentialsInternalCallback(ServerCredentials credentials, Error error);

    public delegate void AuthChangeInternalCallback(LocalPlayerAuthStatus authStatus, Error error);
}