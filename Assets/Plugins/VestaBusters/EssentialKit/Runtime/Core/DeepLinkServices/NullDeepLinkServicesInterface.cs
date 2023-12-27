using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.DeepLinkServicesCore
{
    public class NullDeepLinkServicesInterface : NativeDeepLinkServicesInterfaceBase, INativeDeepLinkServicesInterface
    {
        #region Constructors

        public NullDeepLinkServicesInterface()
            : base(isAvailable: false)
        { }
            
        #endregion

        #region Base methods

        public override void Init()
        {
            Diagnostics.LogNotSupported("DeepLinkServices");
        }

        #endregion
    }
}