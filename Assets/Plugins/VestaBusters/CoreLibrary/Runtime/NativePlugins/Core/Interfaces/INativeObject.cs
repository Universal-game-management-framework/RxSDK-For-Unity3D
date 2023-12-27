using System;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary.NativePlugins
{
    public interface INativeObject : IDisposable
    {
        #region Properties

        NativeObjectRef NativeObjectRef { get; }

        #endregion

        #region Methods

        IntPtr AddrOfNativeObject();

        #endregion
    }
}