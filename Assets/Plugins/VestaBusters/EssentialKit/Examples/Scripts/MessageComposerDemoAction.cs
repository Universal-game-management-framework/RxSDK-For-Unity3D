using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VestaBusters.CoreLibrary.NativePlugins.DemoKit;

namespace VestaBusters.EssentialKit.Demo
{
    public enum MessageComposerDemoActionType
    {
        CanSendText,
        CanSendSubject,
        New,
        SetRecipients,
        SetSubject,
        SetBody,
        Show,
        ResourcePage
    }

    public class MessageComposerDemoAction : DemoActionBehaviour<MessageComposerDemoActionType> 
    {}
}