using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RxToolKit.CoreLibrary
{
    public class FolderBrowserAttribute : PropertyAttribute
    {
        #region Properties

        public bool UsesRelativePath { get; private set; }

        #endregion

        #region Constructors

        public FolderBrowserAttribute(bool usesRelativePath)
        {
            // set properties
            UsesRelativePath    = usesRelativePath;
        }

        #endregion
    }
}