using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RxToolKit.CoreLibrary
{
    public class FileBrowserAttribute : PropertyAttribute
    {
        #region Properties

        public bool UsesRelativePath { get; private set; }

        public string Extension { get; private set; }

        #endregion

        #region Constructors

        public FileBrowserAttribute(bool usesRelativePath, string extension = null)
        {
            // set properties
            UsesRelativePath    = usesRelativePath;
            Extension           = extension;
        }

        #endregion
    }
}