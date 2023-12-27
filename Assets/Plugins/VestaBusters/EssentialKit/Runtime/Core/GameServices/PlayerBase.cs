using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.GameServicesCore
{
    public abstract class PlayerBase : NativeObjectBase, IPlayer
    {
        #region Abstract methods

        protected abstract string GetIdInternal();

        protected abstract string GetAliasInternal();
        
        protected abstract string GetDisplayNameInternal();
        
        protected abstract void LoadImageInternal(LoadImageInternalCallback callback);

        #endregion

        #region Base class methods

        public override string ToString()
        {
            var     sb  = new StringBuilder();
            sb.Append("Player { ");
            sb.Append("Id: ").Append(Id).Append(" ");
            sb.Append("Alias: ").Append(Alias).Append(" ");
            sb.Append("DisplayName: ").Append(DisplayName).Append(" ");
            sb.Append("}");
            return sb.ToString();
        }

        #endregion

        #region IGameServicesPlayer implementation

        public string Id => GetIdInternal();

        public string Alias => GetAliasInternal();

        public string DisplayName => GetDisplayNameInternal();

        public void LoadImage(EventCallback<TextureData> callback)
        {
            LoadImageInternal((imageData, error) =>
            {
                // send result to caller object
                var     data    = (imageData == null) ? null : new TextureData(imageData);
                CallbackDispatcher.InvokeOnMainThread(callback, data, error);
            });
        }

        #endregion
    }
}