#if UNITY_ANDROID

using System;
using VestaBusters.CoreLibrary.NativePlugins;
using VestaBusters.CoreLibrary.NativePlugins.Android;

namespace VestaBusters.EssentialKit.DeepLinkServicesCore.Android
{
    public sealed class DeepLinkServicesInterface : NativeDeepLinkServicesInterfaceBase
    {
        #region Static fields

        private NativeDeepLinkServices m_instance;


        #endregion

        #region Constructors

        public DeepLinkServicesInterface() 
            : base(isAvailable: true)
        {
            m_instance = new NativeDeepLinkServices(NativeUnityPluginUtility.GetContext());
        }

        #endregion

        #region Base methods

        public override void Init()
        {
            m_instance.Initialise(new NativeDeepLinkRequestListener()
            {
                onOpenCallback = (url) =>
                {
                    //Find out what is the type and fire the event
                    SendCustomSchemeUrlOpenEvent(url);
                }
            });
        }

        #endregion
    }
}
#endif