using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.BillingServicesCore
{
    public interface INativeBillingServicesInterface : INativeFeatureInterface
    {
        #region Events

        event RetrieveProductsInternalCallback OnRetrieveProductsComplete;

        event PaymentStateChangeInternalCallback OnTransactionStateChange;

        event RestorePurchasesInternalCallback OnRestorePurchasesComplete;

        #endregion

        #region Methods

        bool CanMakePayments();

        void RetrieveProducts(BillingProductDefinition[] productDefinitions);

        bool StartPayment(IBillingPayment payment, out Error error);

        IBillingTransaction[] GetTransactions();

        void FinishTransactions(IBillingTransaction[] transactions);

        void RestorePurchases(string tag);

        bool TryClearingUnfinishedTransactions();

        #endregion
    }
}