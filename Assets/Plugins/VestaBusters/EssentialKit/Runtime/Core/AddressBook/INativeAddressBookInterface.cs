using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.AddressBookCore
{
    public interface INativeAddressBookInterface : INativeFeatureInterface
    {
        #region Methods

        AddressBookContactsAccessStatus GetContactsAccessStatus();
        
        void RequestContactsAccess(RequestContactsAccessInternalCallback callback);    
        
        void ReadContacts(ReadContactsInternalCallback callback);

        #endregion
    }
}