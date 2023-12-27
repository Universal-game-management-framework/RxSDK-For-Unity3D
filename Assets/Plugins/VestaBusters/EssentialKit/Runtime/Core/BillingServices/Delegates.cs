﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit.BillingServicesCore
{
    public delegate void RetrieveProductsInternalCallback(IBillingProduct[] products, string[] invalidIds, Error error);

    public delegate void PaymentStateChangeInternalCallback(IBillingTransaction[] transactions);

    public delegate void RestorePurchasesInternalCallback(IBillingTransaction[] transactions, Error error);
}