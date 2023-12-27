using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins.UnityUI;
using VestaBusters.EssentialKit.NativeUICore;

namespace VestaBusters.EssentialKit
{
    public partial class NativeUIUnitySettings
    {
        [Serializable]
        public class UnityUICollection
        {
            #region Properties

            [SerializeField]
            [Tooltip("Canvas used to render native plugins components (primarily simulator window).")]
            private     UnityUIRenderer         m_rendererPrefab;

            [SerializeField]
            [Tooltip("Custom alert dialog prefab. Object should implement IUnityUIAlertDialog interface.")]
            private     UnityUIAlertDialog      m_alertDialogPrefab;

            [SerializeField]
            private     UnityUIDatePicker       m_datePickerPrefab;

            #endregion

            #region Properties

            public UnityUIRenderer RendererPrefab
            {
                get => m_rendererPrefab;
                internal set => m_rendererPrefab = value;
            }

            public UnityUIAlertDialog AlertDialogPrefab
            {
                get => m_alertDialogPrefab;
                internal set => m_alertDialogPrefab = value;
            }

            public UnityUIDatePicker DatePickerPrefab
            {
                get => m_datePickerPrefab;
                internal set => m_datePickerPrefab  = value;
            }

            #endregion

            #region Constructors

            public UnityUICollection(UnityUIRenderer rendererPrefab = null, UnityUIAlertDialog alertDialogPrefab = null,
                UnityUIDatePicker datePickerPrefab = null)
            {
                // set properties
                m_rendererPrefab    = rendererPrefab;
                m_alertDialogPrefab = alertDialogPrefab;
                m_datePickerPrefab  = datePickerPrefab;
            }

            #endregion
        }
    }
}