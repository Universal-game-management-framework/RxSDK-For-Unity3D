using UnityEngine;

namespace VestaBusters.CoreLibrary
{
	public abstract class SingletonBehaviour<T> : PrivateSingletonBehaviour<T> where T : MonoBehaviour
	{
        #region Static properties

        /// <summary>
        /// Returns the singleton instance.
        /// </summary>
        /// <value>The instance.</value>
        public static T Instance => GetSingleton();

        #endregion
    }
}