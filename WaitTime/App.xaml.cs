using Autofac;
using Autofac.Core;
using System;
using WaitTime.Services;
using WaitTime.Views;
using WaitTime.Views.AdobeDesing;
using WaitTime.Views.Login;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;

namespace WaitTime
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new login_view());

        }

        
       
        protected override void OnStart()
        {
            /*
            var builder = new ContainerBuilder();
            builder.RegisterType<MyService>().As<IMyService>();
            var container = builder.Build();
            */

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
