using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// key namespaces
using VestaBusters.CoreLibrary.NativePlugins;
using VestaBusters.EssentialKit;
// internal namespace
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public class RateMyAppDemo : DemoActionPanelBase<RateMyAppDemoAction, RateMyAppDemoActionType>
	{
		#region Base methods

        protected override void OnActionSelectInternal(RateMyAppDemoAction selectedAction)
        {
            switch (selectedAction.ActionType)
            {
                case RateMyAppDemoActionType.AskForReviewNow:
					Log("Asking for review."); 
                    RateMyApp.AskForReviewNow();
                    break;

                case RateMyAppDemoActionType.ResourcePage:
                    ProductResources.OpenResourcePage(NativeFeatureType.kRateMyApp);
                    break;

                default:
                    break;
            }
        }

        #endregion
	}
}