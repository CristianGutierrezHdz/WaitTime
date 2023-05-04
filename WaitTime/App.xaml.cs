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

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace WaitTime
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new LoginPage());

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
