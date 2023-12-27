﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;

namespace VestaBusters.EssentialKit
{
    /// <summary>
    /// This class contains the information retrieved when <see cref="WebView.RunJavaScript(string, EventCallback{WebViewRunJavaScriptResult})"/> operation is completed.
    /// </summary>
    public class WebViewRunJavaScriptResult
    {
        #region Properties

        /// <summary>
        /// The result returned on completing js code.
        /// </summary>
        public string Result { get; private set; }

        #endregion

        #region Constructors

        internal WebViewRunJavaScriptResult(string result)
        {
            // Set properties
            Result  = result;
        }

        #endregion
    }
}