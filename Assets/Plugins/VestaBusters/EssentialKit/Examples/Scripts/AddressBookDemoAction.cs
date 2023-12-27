using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
	public enum AddressBookDemoActionType
	{
		GetContactsAccessStatus,
        RequestContactsAccess,
		ReadContacts,
        ReadContactsWithUserPermission,
		ResourcePage,
	}

	public class AddressBookDemoAction : DemoActionBehaviour<AddressBookDemoActionType> 
	{}
}