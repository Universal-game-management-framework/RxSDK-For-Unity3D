using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VestaBusters.CoreLibrary
{
    public interface ILocalisationServiceProvider
    {
        string GetLocalisedString(string key, string defaultValue);
    }
}