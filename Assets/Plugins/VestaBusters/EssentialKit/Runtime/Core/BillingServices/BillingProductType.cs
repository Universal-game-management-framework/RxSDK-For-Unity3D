using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.EssentialKit
{
    /// <summary>
    /// An enumeration for the available billing product types.
    /// </summary>
    public enum BillingProductType
    {
        /// <summary> The consumable product. </summary>
        Consumable,

        /// <summary> The non consumable product. </summary>
        NonConsumable,

        /// <summary> The subscription product. </summary>
        Subscription
    }
}