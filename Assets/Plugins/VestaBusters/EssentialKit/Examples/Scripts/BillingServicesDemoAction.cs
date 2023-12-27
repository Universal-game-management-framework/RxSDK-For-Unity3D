using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum BillingServicesDemoActionType
	{
		InitializeStore,
		CanMakePayments,
        IsProductPurchased,
        BuyProduct,
        GetTransactions,
        FinishTransactions,
        RestorePurchases,
		ResourcePage,
	}

	public class BillingServicesDemoAction : DemoActionBehaviour<BillingServicesDemoActionType> 
	{}
}