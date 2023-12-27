using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit
{
    public static class ProductResources
    {
        #region Constants

        private     const   string      kAddressBookPage                        = "https://assetstore.essentialkit.vestabusters.com/address-book";

        private     const   string      kBillingServicesPage                    = "https://assetstore.essentialkit.vestabusters.com/billing-services";

        private     const   string      kCloudServicesPage                      = "https://assetstore.essentialkit.vestabusters.com/cloud-services";

        private     const   string      kExtrasPage                             = "https://assetstore.essentialkit.vestabusters.com/extras";
        
        private     const   string      kGameServicesPage                       = "https://assetstore.essentialkit.vestabusters.com/game-services";

        private     const   string      kMediaServicesPage                      = "https://assetstore.essentialkit.vestabusters.com/media-services";

        private     const   string      kNetworkServicesPage                    = "https://assetstore.essentialkit.vestabusters.com/network-services";

        private     const   string      kNotificationServicesPage               = "https://assetstore.essentialkit.vestabusters.com/notification-services";

        private     const   string      kRateMyAppPage                          = "https://assetstore.essentialkit.vestabusters.com/rate-my-app";

        private     const   string      kSharingPage                            = "https://assetstore.essentialkit.vestabusters.com/sharing";

        private     const   string      kUIPage                                 = "https://assetstore.essentialkit.vestabusters.com/native-ui";
        
        private     const   string      kWebViewPage                            = "https://assetstore.essentialkit.vestabusters.com/web-view";

        private     const   string      kDeepLinkServicesPage                   = "https://assetstore.essentialkit.vestabusters.com/deep-link-services";
        
        #endregion

        #region Public static methods

        public static void OpenResourcePage(string feature)
        {
            string resourcePage = null;
            switch (feature)
            {
                case NativeFeatureType.kAddressBook:
                    resourcePage    = kAddressBookPage;
                    break;

                case NativeFeatureType.kBillingServices:
                    resourcePage    = kBillingServicesPage;
                    break;

                case NativeFeatureType.kCloudServices:
                    resourcePage    = kCloudServicesPage;
                    break;

                case NativeFeatureType.kDeepLinkServices:
                    resourcePage    = kDeepLinkServicesPage;
                    break;

                case NativeFeatureType.kExtras:
                    resourcePage    = kExtrasPage;
                    break;

                case NativeFeatureType.kGameServices:
                    resourcePage    = kGameServicesPage;
                    break;

                case NativeFeatureType.kMediaServices:
                    resourcePage    = kMediaServicesPage;
                    break;

                case NativeFeatureType.kNetworkServices:
                    resourcePage    = kNetworkServicesPage;
                    break;

                case NativeFeatureType.kNotificationServices:
                    resourcePage    = kNotificationServicesPage;
                    break;

                case NativeFeatureType.kRateMyApp:
                    resourcePage    = kRateMyAppPage;
                    break;

                case NativeFeatureType.kSharingServices:
                    resourcePage    = kSharingPage;
                    break;

                case NativeFeatureType.kNativeUI:
                    resourcePage    = kUIPage;
                    break;

                case NativeFeatureType.kWebView:
                    resourcePage    = kWebViewPage;
                    break;
            }

            // open link
            if (resourcePage != null)
            {
                Application.OpenURL(resourcePage);
            }
        }

        #endregion
    }
}