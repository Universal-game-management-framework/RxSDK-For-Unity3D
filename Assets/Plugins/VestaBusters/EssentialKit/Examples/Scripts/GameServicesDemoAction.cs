using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum GameServicesDemoActionType
	{
        IsAuthenticated,
        Authenticate,
        LocalPlayer,
        Signout,
		LoadLeaderboards,
        ReportScore,
        LoadAchievementDescriptions,
        LoadAchievements,
        ReportAchievementProgress,
        GetNumOfStepsRequiredToUnlockAchievement,
        ShowLeaderboards,
        ShowAchievements,
        LoadServerCredentials,
		ResourcePage,
	}

	public class GameServicesDemoAction : DemoActionBehaviour<GameServicesDemoActionType> 
	{}
}