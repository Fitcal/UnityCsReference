// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

namespace UnityEditor.Collaboration
{
    internal interface IVersionControl
    {
        bool OnEnableVersionControl();
        void OnDisableVersionControl();
        ChangeItem[] GetChanges();
    }
}
