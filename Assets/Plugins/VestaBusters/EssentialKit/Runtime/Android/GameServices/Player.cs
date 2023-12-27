﻿#if UNITY_ANDROID
using System;

using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins;
using VestaBusters.CoreLibrary.NativePlugins.Android;
using VestaBusters.EssentialKit.Common.Android;

namespace VestaBusters.EssentialKit.GameServicesCore.Android
{
    internal class Player : PlayerBase
    {
#region Fields

        protected NativeGamePlayer m_instance;

#endregion
#region Constructors

        public Player(NativeGamePlayer nativePlayer)
        {
            m_instance = nativePlayer;
        }

        ~Player()
        {
            Dispose(false);
        }

#endregion

#region Base class methods

        protected override string GetIdInternal()
        {
            if(m_instance == null)
            {
                return null;
            }

            return m_instance.GetId();
        }

        protected override string GetAliasInternal()
        {
            if(m_instance == null)
            {
                return null;
            }

            return m_instance.GetName();
        }

        protected override string GetDisplayNameInternal()
        {
            if(m_instance == null)
            {
                return null;
            }

            return m_instance.GetDisplayName();
        }

        protected override void LoadImageInternal(LoadImageInternalCallback callback)
        {
            if(m_instance == null)
            {
                callback(null, new Error("Player not available"));
                return;
            }

            //#warning What needs to be done if no image exists? How its handled on iOS. Any option for setting default image in settings? Current one just passes null if no image exists without error
            m_instance.LoadProfileImage(true, new NativeLoadAssetListener()
                {
                    onSuccessCallback = (NativeBytesWrapper data) =>
                    {
                        callback(data.GetBytes(), null);
                    },
                    onFailureCallback = (error) =>
                    {
                        callback(null, new Error(error));
                    }
                });
        }

#endregion
    }
}
#endif