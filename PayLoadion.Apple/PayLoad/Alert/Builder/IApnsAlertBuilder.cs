﻿using System;
using PayLoadion.Builder;

namespace PayLoadion.Apple.PayLoad.Alert.Builder
{
    public interface IApnsAlertBuilder : IBuilder<IApnsAlert>, IDisposable
    {
        IApnsAlertBuilder Title(string title);
        IApnsAlertBuilder Body(string body);
        IApnsAlertBuilder TitleLocalizableKey(string titleLocKey);
        IApnsAlertBuilder AddTitleLocalizableArgument(string titleLocArgument);
        IApnsAlertBuilder ActionLocalizableKey(string actionLocalizableKey);
        IApnsAlertBuilder LocalizableKey(string localizableKey);
        IApnsAlertBuilder AddLocalizableArgument(string titleLocalizableArgument);
        IApnsAlertBuilder LaunchImageFileName(string launchImageFileName);
    }
}