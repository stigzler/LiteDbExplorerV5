﻿using System.ComponentModel;

namespace LiteDbExplorer.Framework.Shell
{
    public interface IShellStatusBar : INotifyPropertyChanged
    {
        IStatusBarContent ActivateContent(IStatusBarContent content, StatusBarContentLocation location);
        void DeactivateContent(string instanceId);
        void DeactivateContent(IStatusBarContent content);
    }
}