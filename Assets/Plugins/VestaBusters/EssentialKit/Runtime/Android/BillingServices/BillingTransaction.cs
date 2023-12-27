﻿#if UNITY_ANDROID
using System;
using VestaBusters.CoreLibrary;


namespace VestaBusters.EssentialKit.BillingServicesCore.Android
{
    internal sealed class BillingTransaction : BillingTransactionBase
    {
        #region Fields

        private NativeBillingTransaction m_instance;
        private Error m_error;

        #endregion

        #region Constructors

        public BillingTransaction(NativeBillingTransaction nativeBillingTransaction)
            : this(nativeBillingTransaction, null)
        {
           
        }

        public BillingTransaction(NativeBillingTransaction nativeBillingTransaction, Error error)
            : base(transactionId: nativeBillingTransaction.GetId(), payment: CreateBillingPayment(nativeBillingTransaction))
        {
            m_instance = nativeBillingTransaction;
            m_error = error;
        }

        ~BillingTransaction()
        {
            Dispose(false);
        }

        #endregion

        #region Base methods

        protected override DateTime GetTransactionDateUTCInternal()
        {
            return m_instance.GetPurchaseDate().GetDateTime();
        }

        protected override BillingTransactionState GetTransactionStateInternal()
        {
            return Converter.from(m_instance.GetState());
        }

        protected override BillingReceiptVerificationState GetReceiptVerificationStateInternal()
        {
            return Converter.from(m_instance.GetVerificationState());
        }

        protected override void SetReceiptVerificationStateInternal(BillingReceiptVerificationState value)
        {
            m_instance.SetVerificationState(Converter.from(value));
        }

        protected override string GetReceiptInternal()
        {
            return m_instance.GetReceipt(); // This is equal to purchaseToken now in 2.0v
        }

        protected override Error GetErrorInternal()
        {
            return m_error;
        }

        #endregion

        #region Utility methods

        private static BillingPayment CreateBillingPayment(NativeBillingTransaction nativeBillingTransaction)
        {
            string  productPlatformId   = nativeBillingTransaction.GetProductIdentifier();
            var     productDefinition   = BillingServices.FindProductDefinitionWithPlatformId(productPlatformId, returnObjectOnFail: true);
            return new BillingPayment(
                productId: productDefinition.Id,
                productPlatformId: productPlatformId,
                quantity: nativeBillingTransaction.GetQuantity(),
                tag: nativeBillingTransaction.GetUserTag());
        }

        protected override BillingTransactionAndroidProperties GetAndroidPropertiesInternal()
        {
            BillingTransactionAndroidProperties androidProperties = new BillingTransactionAndroidProperties(m_instance.GetPurchaseData(), m_instance.GetSignature());
            return androidProperties;
        }

        #endregion
    }
}
#endif