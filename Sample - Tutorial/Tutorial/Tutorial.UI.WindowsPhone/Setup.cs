﻿using System;
using System.Collections.Generic;
using Cirrious.CrossCore.Interfaces.IoC;
using Cirrious.CrossCore.Interfaces.Platform;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.WindowsPhone.Platform;
using Microsoft.Phone.Controls;

namespace Tutorial.UI.WindowsPhone
{
    public class Setup
        : MvxWindowsPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame)
            : base(rootFrame)
        {
        }

        protected override MvxApplication CreateApp()
        {
            var app = new Core.App();
            return app;
        }

        protected override IMvxNavigationRequestSerializer CreateNavigationRequestSerializer()
        {
            Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
            var json = Mvx.Resolve<IMvxJsonConverter>();
            return new MvxNavigationRequestSerializer(json);
        }

        protected override void InitializeLastChance()
        {
            Cirrious.MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();

            base.InitializeLastChance();
        }
    }
}
