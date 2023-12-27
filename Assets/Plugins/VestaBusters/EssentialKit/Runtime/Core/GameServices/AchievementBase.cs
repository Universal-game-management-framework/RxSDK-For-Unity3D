﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using VestaBusters.CoreLibrary;
using VestaBusters.CoreLibrary.NativePlugins;

namespace VestaBusters.EssentialKit.GameServicesCore
{
    public abstract class AchievementBase : NativeObjectBase, IAchievement
    {
        #region Constructors

        protected AchievementBase(string id, string platformId)
        {
            // set properties
            Id              = id;
            PlatformId      = platformId;
        }

        #endregion

        #region Abstract methods

        protected abstract double GetPercentageCompletedInternal();

        protected abstract void SetPercentageCompletedInternal(double value);
        
        protected abstract bool GetIsCompletedInternal();

        protected abstract DateTime GetLastReportedDateInternal();

        protected abstract void ReportProgressInternal(ReportAchievementProgressInternalCallback callback);

        #endregion

        #region Base class methods

        public override string ToString()
        {
            var     sb  = new StringBuilder();
            sb.Append("Achievement {");
            sb.Append("Id: ").Append(Id).Append(" ");
            sb.Append("PercentageCompleted: ").Append(PercentageCompleted).Append(" ");
            sb.Append("IsCompleted: ").Append(IsCompleted).Append(" ");
            sb.Append("LastReportedDate: ").Append(LastReportedDate).Append(" ");
            sb.Append("}");
            return sb.ToString();
        }

        #endregion

        #region IGameServicesAchievement implementation

        public string Id { get; internal set; }

        public string PlatformId { get; internal set; }

        public double PercentageCompleted
        {
            get => GetPercentageCompletedInternal();
            set => SetPercentageCompletedInternal(value);
        }

        public bool IsCompleted => GetIsCompletedInternal();

        public DateTime LastReportedDate => GetLastReportedDateInternal();

        public void ReportProgress(CompletionCallback callback)
        {
            // retain object to avoid unintentional release
            ManagedObjectReferencePool.Retain(this);

            // make call
            ReportProgressInternal((success, error) =>
            {
                // send result to caller object
                CallbackDispatcher.InvokeOnMainThread(callback, success, error);

                // remove object from cache
                ManagedObjectReferencePool.Release(this);
            });
        }

        [Obsolete("This method is deprecated. Use ReportProgress(CompletionCallback) method instead.", false)]
        public void ReportProgress(CompletionCallbackLegacy callback)
        {
            ReportProgress((success, error) =>
            {
                callback?.Invoke(error);
            });
        }

        #endregion
    }
}