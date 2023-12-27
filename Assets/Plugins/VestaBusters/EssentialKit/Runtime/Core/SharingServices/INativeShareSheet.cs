using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.SharingServicesCore
{
    public interface INativeShareSheet : INativeObject
    {
        #region Events

        event ShareSheetClosedInternalCallback OnClose;

        #endregion

        #region Methods

        // attachment methods
        void AddText(string text);

        void AddScreenshot();
        
        void AddImage(byte[] imageData, string mimeType);

        void AddAttachment(byte[] data, string mimeType, string filename);

        void AddURL(URLString url);

        // presentation methods
        void Show(Vector2 screenPosition);

        #endregion
    }
}