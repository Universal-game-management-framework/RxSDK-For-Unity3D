using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
    /// <summary>
    /// Base interface that all event handlers inherit from.
    /// </summary>
    [IncludeInDocs]
    public interface IEventHandler
    {
        int CallbackOrder { get; }
    }
}